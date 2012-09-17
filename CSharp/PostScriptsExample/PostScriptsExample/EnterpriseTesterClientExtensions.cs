using System.Net;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostScriptsExample
{
    public static class EnterpriseTesterClientExtensions
    {
        public static Project GetProjectByName(this RestClient client, string name)
        {
            var request = new RestRequest("projects", Method.GET)
                .AddParameter("tql", string.Format("Name~'{0}'", name))
                .AddParameter("$expand", "Priorities,Statuses,TestTypes");

            IRestResponse<Collection<Project>> response = client.Execute<Collection<Project>>(request);

            if (response.ErrorMessage != null)
            {
                throw new Exception(response.ErrorMessage);
            }

            if (response.Data.Items.Count == 0) throw new ArgumentException("Could not find project with name: " + name, "name");

            return response.Data.Items[0];
        }

        public static Package GetPackageByProjectAndName(this RestClient client, string projectName, string packageName)
        {
            var request = new RestRequest("scriptpackages", Method.GET)
                .AddParameter("tql", string.Format("Name~'{0}' AND Project='{1}'", packageName, projectName));

            IRestResponse<Collection<Package>> response = client.Execute<Collection<Package>>(request);

            if (response.ErrorMessage != null)
            {
                throw new Exception(response.ErrorMessage);
            }

            if (response.Data.Items.Count == 0) throw new ArgumentException("Could not find script package with name: " + packageName, "packageName");

            return response.Data.Items[0];
        }

        public static CreatedInfo PostScript(this RestClient client, Script script)
        {

            var request = new RestRequest("scripts", Method.POST) { RequestFormat = DataFormat.Json }
                .AddBody(script);

            var response = client.Execute<CreatedInfo>(request);

            if (response.ErrorMessage != null)
            {
                throw new Exception(response.ErrorMessage);
            }

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return response.Data;
            }
            else
            {
                throw new Exception(string.Format("Failed to create script, error was: {0}", response.Content));
            }
        }
    }
}
