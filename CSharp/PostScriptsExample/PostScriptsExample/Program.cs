using System.Net;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostScriptsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: replace with path to API, username and password on your ET test server

            string baseUrl = "http://localhost/EnterpriseTester/api/";
            string username = "Administrator";
            string password = "password";

            var client = new RestClient(baseUrl)
            {
                Authenticator = new HttpBasicAuthenticator(username,password)
            };

            var project = client.GetProjectByName("Baseline1");

            var targetPackage = client.GetPackageByProjectAndName("Baseline1", "Script Library");

            var scripts = GetScripts(targetPackage, project);

            foreach (var script in scripts)
            {
                var result = client.PostScript(script);

                Console.WriteLine("Created new script with id: {0}, self: {1}", result.Id, result.Self);
            }

            Console.WriteLine();

            Console.WriteLine("Add done, press <enter> to exit.");

            Console.ReadLine();
        }

        static IEnumerable<Script> GetScripts(Package target, Project project)
        {
            // TODO: replace this with something that reads from a file/database/wherever script info is stored

            yield return new Script
            {
                Name = "Script 1",
                PackageId = target.Id,
                PriorityId = project.ResolvePriorityId("Medium"),
                StatusId = project.ResolveStatusId("In Progress"),
                TypeId = project.ResolveTypeID("Functional"),
                Steps = new List<Step>
                        {
                            new Step {Description = "Do This", ExpectedResult = "Expect That"},
                            new Step {Description = "Then Do This", ExpectedResult = "And also expect this"},
                            new Step {Description = "Finally do thsi", ExpectedResult = "and expect this"}
                        }
            };

            yield return new Script
            {
                Name = "Script 2",
                PackageId = target.Id,
                PriorityId = project.ResolvePriorityId("Medium"),
                StatusId = project.ResolveStatusId("In Progress"),
                TypeId = project.ResolveTypeID("Functional"),
                Steps = new List<Step>
                        {
                            new Step {Description = "Do This", ExpectedResult = "Expect That"},
                            new Step {Description = "Then Do This", ExpectedResult = "And also expect this"},
                            new Step {Description = "Finally do thsi", ExpectedResult = "and expect this"}
                        }
            };

            yield return new Script
            {
                Name = "Script 3",
                PackageId = target.Id,
                PriorityId = project.ResolvePriorityId("High"),
                StatusId = project.ResolveStatusId("In Progress"),
                TypeId = project.ResolveTypeID("User Acceptance"),
                Steps = new List<Step>
                        {
                            new Step {Description = "Do This", ExpectedResult = "Expect That"},
                            new Step {Description = "Then Do This", ExpectedResult = "And also expect this"},
                            new Step {Description = "Finally do thsi", ExpectedResult = "and expect this"}
                        }
            };
        }        
    }
}
