using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using CommandLine;
using CommandLine.Text;
using RestSharp;

namespace RelationshipCreator
{
    internal class Program
    {
        static readonly HeadingInfo HeadingInfo = new HeadingInfo("RelationshipCreator", "1.0");

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

            Organisation org = client.GetOrganisation(root);


            Stopwatch watch = Stopwatch.StartNew();

            CreateAllRelationships(client, root, options, org);

            Console.WriteLine("Completed in {0} - press enter to exit.", watch.Elapsed);

            Console.ReadLine();

            Environment.Exit(0);
        }

        static void CreateAllRelationships(RestClient client, Root root, Options options, Organisation org)
        {
            var source = new DataSource();

            List<RequirementToScriptRel> data = source.GetRequirementToScriptRelationships().ToList();

            for (int i = 0; i < data.Count; i++)
            {
                int zephyrTestCaseId = data[i].TestCaseId;
                int zephyrRequirementId = data[i].RequirementId;

                Console.WriteLine("{0} of {1}: Creating relationship between test case #{2} and requirement #{3}", i + 1, data.Count, zephyrTestCaseId, zephyrRequirementId);

                CreateRelationship(client, root, zephyrTestCaseId, zephyrRequirementId, options, org);
            }
        }

        static void CreateRelationship(RestClient client, Root root, int zephyrTestCaseId, int zephyrRequirementId, Options options, Organisation org)
        {
            Script script = client.GetScriptByZephyrId(root, zephyrTestCaseId);

            Requirement requirement = client.GetRequirementByZephyrId(root, zephyrRequirementId);

            try
            {
                client.CreateRelationshipBetweenScriptAndRequirement(options.Server, org.Id, script.Id, requirement.Id);
            }
            catch (RelationshipExistsException)
            {
                Console.WriteLine("  => Relationship already exists!");
            }
        }
    }
}