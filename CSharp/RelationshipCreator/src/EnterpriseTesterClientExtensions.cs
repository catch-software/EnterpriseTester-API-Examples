using System;
using System.Linq;
using System.Net;
using RestSharp;

namespace RelationshipCreator
{
    public static class EnterpriseTesterClientExtensions
    {
        public static Organisation GetOrganisation(this RestClient client, Root root)
        {
            IRestRequest request = new RestRequest(root.GetLink("Organisations"), Method.GET);
            var org = ExecuteFirstItemCollectionRequest<Organisation>(client, request);
            // work around bug in API where the Organisation ID is never returned as you would expect
            // this bug was resolved in ET v4.6
            org.Id = new Guid(org.Self.Split(new[] {"/"}, StringSplitOptions.RemoveEmptyEntries).Last());
            return org;
        }

        public static Root GetRoot(this RestClient client, string server)
        {
            if (!server.EndsWith("/")) server = server + "/";

            string apiUrl = server + "api";

            var request = new RestRequest(apiUrl, Method.GET);

            return ExecuteRequest<Root>(client, request);
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

        public static Requirement GetRequirementByZephyrId(this RestClient client, Root root, int zephyrId)
        {
            IRestRequest request = new RestRequest(root.GetLink("Requirements"), Method.GET) {RequestFormat = DataFormat.Json}
                .AddParameter("tql", string.Format("RequirementZephyrId = {0}", zephyrId));

            return ExecuteFirstItemCollectionRequest<Requirement>(client, request);
        }

        public static Script GetScriptByZephyrId(this RestClient client, Root root, int zephyrId)
        {
            IRestRequest request = new RestRequest(root.GetLink("Scripts"), Method.GET) {RequestFormat = DataFormat.Json}
                .AddParameter("tql", string.Format("ScriptZephyrId = {0}", zephyrId));

            return ExecuteFirstItemCollectionRequest<Script>(client, request);
        }

        public static Relationship CreateRelationshipBetweenScriptAndRequirement(this RestClient client, string server, Guid organisationId, Guid scriptId, Guid requirementId)
        {
            if (!server.EndsWith("/")) server = server + "/";

            string apiUrl = server + "api";

            string relationshipUrl = string.Format("{0}/organisation/{1}/relationshiptype/ScriptToRequirementCoverage/relationships", apiUrl, organisationId);

            var model = new CreateRelationshipModel
                {
                    RelationshipDirection = "SourceToDestination",
                    SourceEntityId = scriptId,
                    SourceEntityType = "TestScript",
                    DestinationEntityId = requirementId,
                    DestinationEntityType = "Requirement"
                };

            IRestRequest request = new RestRequest(relationshipUrl, Method.POST) {RequestFormat = DataFormat.Json}
                .AddBody(model);

            IRestResponse<Relationship> response = client.Execute<Relationship>(request);

            if (response.ErrorMessage != null)
            {
                throw new Exception(response.ErrorMessage);
            }

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return response.Data;
            }

            if (response.Content.Contains("A relationship of this type already exists"))
            {
                throw new RelationshipExistsException();
            }

            throw new Exception(string.Format("Failed to create relationship, error was: {0}", response.Content));
        }
    }
}