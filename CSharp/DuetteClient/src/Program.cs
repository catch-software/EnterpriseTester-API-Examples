using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using CommandLine;
using CommandLine.Text;
using Ionic.Zip;
using RestSharp;

namespace EnterpriseTester.DuetteClient
{
    internal class Program
    {
        static readonly HeadingInfo HeadingInfo = new HeadingInfo("DuetteClient", "1.0");

        static void Main(string[] args)
        {
            ServicePointManager.UseNagleAlgorithm = false;

            Console.WriteLine(HeadingInfo);

            var options = new Options();

            var parser = new CommandLineParser(new CommandLineParserSettings(Console.Error));

            if (!parser.ParseArguments(args, options))
            {
                Environment.Exit(1);
            }

            var client = new RestClient
                {
                    Authenticator = new HttpBasicAuthenticator(options.UserName, options.Password)
                };

            Root root = client.GetRoot(options.Server);

            SystemInfo systemInfo = client.GetSystemInfo(root);

            Project project = GetProject(client, root, options);

            Package scriptPackage = FindOrCreateScriptPackage(client, root, project, options, systemInfo);

            AutomatedTest automatedTest = FindOrCreateAutomatedTest(client, root, scriptPackage, options);

            Package executionPackage = FindOrCreateExecutionPackage(client, root, project, options, systemInfo);

            AutomatedTestAssignment automatedTestAssignment = FindOrCreateAutomatedTestAssignment(client, root, executionPackage, automatedTest);

            IRestResponse<BackgroundTask> progress = StartUploadResults(automatedTestAssignment, options, client);

            PollTaskProgress(client, progress);

            Environment.Exit(0);
        }

        static Project GetProject(RestClient client, Root root, Options options)
        {
            Project project = client.GetProjectByName(root, options.Project);

            if (project == null)
            {
                Console.WriteLine("Project '{0}' does not exist.", options.Project);
                Environment.Exit(1);
            }
            return project;
        }

        static string CreateFileToUpload(IList<string> files)
        {
            if (files == null || files.Count == 0)
            {
                Console.WriteLine("No files were supplied");
                Environment.Exit(1);
            }

            string temporaryFile = Path.GetTempFileName() + ".zip";

            using (var zip = new ZipFile())
            {
                foreach (string file in files)
                {
                    if (File.Exists(file) || Directory.Exists(file))
                    {
                        zip.AddItem(file);
                    }
                    else if (file.Contains("*") || file.Contains("?"))
                    {
                        string parent = Path.GetDirectoryName(file);

                        if (parent == null)
                        {
                            Console.WriteLine("Unabled to find file or folder: {0}", file);
                            Environment.Exit(10);
                        }

                        string wildCard = Path.GetFileName(file);

                        if (wildCard == null)
                        {
                            Console.WriteLine("Unabled to find file or folder: {0}", file);
                            Environment.Exit(10);
                        }

                        foreach (FileInfo fileInPattern in new DirectoryInfo(parent).GetFiles(wildCard))
                        {
                            zip.AddItem(fileInPattern.FullName);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Unabled to find file or folder: {0}", file);
                        Environment.Exit(10);
                    }
                }

                zip.Save(temporaryFile);
            }

            return temporaryFile;
        }

        static IRestResponse<BackgroundTask> StartUploadResults(AutomatedTestAssignment automatedTestAssignment, Options options, RestClient client)
        {
            string fileToUpload = CreateFileToUpload(options.ResultFiles);

            try
            {
                if (options.SaveCopy)
                {
                    string copyPath = Path.Combine(Environment.CurrentDirectory, "report.zip");
                    File.Copy(fileToUpload, copyPath);
                }

                IRestRequest request = new RestRequest(automatedTestAssignment.GetLink("Runs"), Method.POST).AddHeader("Content-Type", "multipart/mixed");

                string path = Path.GetFullPath(fileToUpload);

                request.AddFile("report", path);

                IRestResponse<BackgroundTask> result = client.Execute<BackgroundTask>(request);

                if (result.ErrorMessage != null)
                {
                    Console.WriteLine("Error occured while uploading results: {0}", result.ErrorMessage);
                    Environment.Exit(3);
                }

                if (result.StatusCode != HttpStatusCode.Accepted)
                {
                    Console.WriteLine("Error occured while uploading results: {0}", result.Content);
                    Environment.Exit(4);
                }

                return result;
            }
            finally
            {
                File.Delete(fileToUpload);
            }
        }

        static void PollTaskProgress(RestClient client, IRestResponse<BackgroundTask> progress)
        {
            while (true)
            {
                Thread.Sleep(100);

                progress = client.Execute<BackgroundTask>(new RestRequest(progress.Data.Self));

                if (progress.ErrorMessage != null)
                {
                    throw new Exception(progress.ErrorMessage);
                }

                if (progress.StatusCode != HttpStatusCode.OK)
                {
                    Console.WriteLine("Failed to retrieve task progress, error was: {0}", progress.Content);
                }

                if (progress.Data.Complete)
                {
                    Console.WriteLine("Import completed");
                    break;
                }

                if (!string.IsNullOrEmpty(progress.Data.Error))
                {
                    Console.WriteLine("Error occured executing task: {0}", progress.Data.Error);
                    Environment.Exit(2);
                }

                Console.Write(".");
            }
        }

        static AutomatedTestAssignment FindOrCreateAutomatedTestAssignment(RestClient client, Root root, Package executionPackage, AutomatedTest automatedTest)
        {
            if (automatedTest.Id == null) throw new ArgumentException("automatedTest");

            AutomatedTestAssignment automatedTestAssignment = client.GetAutomatedTestAssignmentByPackageAndTestId(root, executionPackage.Id, automatedTest.Id.Value) ??
                                                              client.CreateAutomatedTestAssignmentInPackageId(root, executionPackage.Id, automatedTest.Id.Value);

            return automatedTestAssignment;
        }

        static AutomatedTest FindOrCreateAutomatedTest(RestClient client, Root root, Package scriptPackage, Options options)
        {
            AutomatedTest automatedTest = client.GetAutomatedTestByPackageAndTestName(root, scriptPackage.Id, options.TestName) ?? client.CreateAutomatedTest(root, scriptPackage.Id, options.TestName, options.Type, options.SubType);

            return automatedTest;
        }

        static Package FindOrCreateScriptPackage(RestClient client, Root root, Project project, Options options, SystemInfo systemInfo)
        {
            Package scriptPackage = client.GetScriptPackageByProjectAndName(root, project.Id, options.ScriptPackage);

            if (scriptPackage == null)
            {
                // let's try to create all the packages in the path

                string[] parts = options.ScriptPackage.Split(new[] {systemInfo.PackagePathSeparator}, StringSplitOptions.RemoveEmptyEntries);

                Package parent = client.GetScriptPackageByProjectAndName(root, project.Id, parts[0]) ?? client.CreateScriptPackageForProject(root, project.Id, parts[0]);

                for (int i = 1; i < parts.Length; i++)
                {
                    Package match = client.GetScriptPackageByParentPackageAndName(root, parent.Id, parts[i]) ?? client.CreateScriptPackageForParentProject(root, parent.Id, parts[i]);

                    parent = match;
                }

                scriptPackage = parent;
            }

            return scriptPackage;
        }

        static Package FindOrCreateExecutionPackage(RestClient client, Root root, Project project, Options options, SystemInfo systemInfo)
        {
            Package scriptPackage = client.GetExecutionPackageByProjectAndName(root, project.Id, options.ExecutionPackage);

            if (scriptPackage == null)
            {
                // let's try to create all the packages in the path

                string[] parts = options.ExecutionPackage.Split(new[] {systemInfo.PackagePathSeparator}, StringSplitOptions.RemoveEmptyEntries);

                Package parent = client.GetExecutionPackageByProjectAndName(root, project.Id, parts[0]) ?? client.CreateExecutionPackageForProject(root, project.Id, parts[0]);

                for (int i = 1; i < parts.Length; i++)
                {
                    Package match = client.GetExecutionPackageByParentPackageAndName(root, parent.Id, parts[i]) ?? client.CreateExecutionPackageForParentProject(root, parent.Id, parts[i]);

                    parent = match;
                }

                scriptPackage = parent;
            }

            return scriptPackage;
        }
    }
}