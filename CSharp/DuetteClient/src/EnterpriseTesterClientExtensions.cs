using System;
using System.Net;
using RestSharp;

namespace EnterpriseTester.DuetteClient
{
    public static class EnterpriseTesterClientExtensions
    {
        public static Project GetProjectByName(this RestClient client, Root root, string name)
        {
            IRestRequest request = new RestRequest(root.GetLink("Projects"), Method.GET)
                .AddParameter("$filter", string.Format("Name eq '{0}'", name));

            return ExecuteFirstItemCollectionRequest<Project>(client, request);
        }

        public static Root GetRoot(this RestClient client, string server)
        {
            if (!server.EndsWith("/")) server = server + "/";

            string apiUrl = server + "api";

            var request = new RestRequest(apiUrl, Method.GET);

            return ExecuteRequest<Root>(client, request);
        }

        public static SystemInfo GetSystemInfo(this RestClient client, Root root)
        {
            var request = new RestRequest(root.GetLink("SystemInfo"), Method.GET);

            return ExecuteRequest<SystemInfo>(client, request);
        }

        static T ExecuteRequest<T>(RestClient client, IRestRequest request)
            where T : class, new()
        {
            IRestResponse<T> response = client.Execute<T>(request);

            if (response.ErrorMessage != null)
            {
                throw new Exception(response.ErrorMessage);
            }

            return response.Data;
        }

        static T ExecuteFirstItemCollectionRequest<T>(RestClient client, IRestRequest request)
            where T : class, new()
        {
            IRestResponse<Collection<T>> response = client.Execute<Collection<T>>(request);

            if (response.ErrorMessage != null)
            {
                throw new Exception(response.ErrorMessage);
            }

            if (response.Data.Items.Count == 1)
            {
                return response.Data.Items[0];
            }

            return null;
        }

        public static Package GetScriptPackageByProjectAndName(this RestClient client, Root root, Guid projectId, string packageName)
        {
            IRestRequest request = new RestRequest(root.GetLink("ScriptPackages"), Method.GET)
                .AddParameter("tql", string.Format("Id IN Packages('{0}') AND Project='{1}'", packageName, projectId));

            return ExecuteFirstItemCollectionRequest<Package>(client, request);
        }

        public static Package GetExecutionPackageByProjectAndName(this RestClient client, Root root, Guid projectId, string packageName)
        {
            IRestRequest request = new RestRequest(root.GetLink("ExecutionPackages"), Method.GET)
                .AddParameter("tql", string.Format("Id IN Packages('{0}') AND Project='{1}'", packageName, projectId));

            return ExecuteFirstItemCollectionRequest<Package>(client, request);
        }

        public static Package GetScriptPackageByParentPackageAndName(this RestClient client, Root root, Guid parentPackageId, string packageName)
        {
            IRestRequest request = new RestRequest(root.GetLink("ScriptPackages"), Method.GET)
                .AddParameter("tql", string.Format("Id IN Packages('{0}') AND Package='{1}'", packageName, parentPackageId));

            return ExecuteFirstItemCollectionRequest<Package>(client, request);
        }

        public static Package GetExecutionPackageByParentPackageAndName(this RestClient client, Root root, Guid parentPackageId, string packageName)
        {
            IRestRequest request = new RestRequest(root.GetLink("ExecutionPackages"), Method.GET)
                .AddParameter("tql", string.Format("Id IN Packages('{0}') AND Package='{1}'", packageName, parentPackageId));

            return ExecuteFirstItemCollectionRequest<Package>(client, request);
        }

        public static Package CreateScriptPackageForProject(this RestClient client, Root root, Guid projectId, string packageName)
        {
            IRestRequest request = new RestRequest(root.GetLink("ScriptPackages"), Method.POST) {RequestFormat = DataFormat.Json}
                .AddBody(new Package {ProjectId = projectId, Name = packageName});

            IRestResponse<Package> response = client.Execute<Package>(request);

            if (response.ErrorMessage != null)
            {
                throw new Exception(response.ErrorMessage);
            }

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return response.Data;
            }

            throw new Exception(string.Format("Failed to create script package, error was: {0}", response.Content));
        }

        public static Package CreateExecutionPackageForProject(this RestClient client, Root root, Guid projectId, string packageName)
        {
            IRestRequest request = new RestRequest(root.GetLink("ExecutionPackages"), Method.POST) {RequestFormat = DataFormat.Json}
                .AddBody(new Package {ProjectId = projectId, Name = packageName});

            IRestResponse<Package> response = client.Execute<Package>(request);

            if (response.ErrorMessage != null)
            {
                throw new Exception(response.ErrorMessage);
            }

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return response.Data;
            }

            throw new Exception(string.Format("Failed to create execution package, error was: {0}", response.Content));
        }

        public static Package CreateScriptPackageForParentProject(this RestClient client, Root root, Guid parentPackageId, string packageName)
        {
            IRestRequest request = new RestRequest(root.GetLink("ScriptPackages"), Method.POST) {RequestFormat = DataFormat.Json}
                .AddBody(new Package {ParentId = parentPackageId, Name = packageName});

            IRestResponse<Package> response = client.Execute<Package>(request);

            if (response.ErrorMessage != null)
            {
                throw new Exception(response.ErrorMessage);
            }

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return response.Data;
            }

            throw new Exception(string.Format("Failed to create script package, error was: {0}", response.Content));
        }

        public static Package CreateExecutionPackageForParentProject(this RestClient client, Root root, Guid parentPackageId, string packageName)
        {
            IRestRequest request = new RestRequest(root.GetLink("ExecutionPackages"), Method.POST) {RequestFormat = DataFormat.Json}
                .AddBody(new Package {ParentId = parentPackageId, Name = packageName});

            IRestResponse<Package> response = client.Execute<Package>(request);

            if (response.ErrorMessage != null)
            {
                throw new Exception(response.ErrorMessage);
            }

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return response.Data;
            }

            throw new Exception(string.Format("Failed to create execution package, error was: {0}", response.Content));
        }

        public static AutomatedTest GetAutomatedTestByPackageAndTestName(this RestClient client, Root root, Guid packageId, string testName)
        {
            IRestRequest request = new RestRequest(root.GetLink("AutomatedTests"), Method.GET) {RequestFormat = DataFormat.Json}
                .AddParameter("tql", string.Format("Name~'{0}' AND Package='{1}'", testName, packageId));

            return ExecuteFirstItemCollectionRequest<AutomatedTest>(client, request);
        }

        public static AutomatedTest CreateAutomatedTest(this RestClient client, Root root, Guid packageId, string testName, string type, string subType)
        {
            var model = new AutomatedTest {PackageId = packageId, Name = testName, Type = type};

            if (!string.IsNullOrEmpty(subType))
            {
                model.Configuration = new AutomatedTestConfiguration {Type = subType};
            }

            IRestRequest request = new RestRequest(root.GetLink("AutomatedTests"), Method.POST) {RequestFormat = DataFormat.Json}
                .AddBody(model);

            IRestResponse<AutomatedTest> response = client.Execute<AutomatedTest>(request);

            if (response.ErrorMessage != null)
            {
                throw new Exception(response.ErrorMessage);
            }

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return response.Data;
            }

            throw new Exception(string.Format("Failed to create automated test, error was: {0}", response.Content));
        }

        public static AutomatedTestAssignment GetAutomatedTestAssignmentByPackageAndTestId(this RestClient client, Root root, Guid packageId, Guid testId)
        {
            IRestRequest request = new RestRequest(root.GetLink("AutomatedTestAssignments"), Method.GET) {RequestFormat = DataFormat.Json}
                .AddParameter("tql", string.Format("TestId={0} AND Package={1}", testId, packageId));

            return ExecuteFirstItemCollectionRequest<AutomatedTestAssignment>(client, request);
        }

        public static AutomatedTestAssignment CreateAutomatedTestAssignmentInPackageId(this RestClient client, Root root, Guid packageId, Guid testId)
        {
            var model = new AutomatedTestAssignment
                {
                    PackageId = packageId,
                    AutomatedTestId = testId
                };

            IRestRequest request = new RestRequest(root.GetLink("AutomatedTestAssignments"), Method.POST) {RequestFormat = DataFormat.Json}
                .AddBody(model);

            IRestResponse<AutomatedTestAssignment> response = client.Execute<AutomatedTestAssignment>(request);

            if (response.ErrorMessage != null)
            {
                throw new Exception(response.ErrorMessage);
            }

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return response.Data;
            }

            throw new Exception(string.Format("Failed to create automated test assignment, error was: {0}", response.Content));
        }
    }
}