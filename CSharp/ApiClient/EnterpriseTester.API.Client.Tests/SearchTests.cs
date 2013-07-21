using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Xunit;

namespace EnterpriseTester.API.Client.Tests
{
    /// <summary>
    /// Example demonstrating aggregate search
    /// </summary>
    public class SearchTests
    {
        private readonly Client client;

        public SearchTests()
        {
            client = new Client("http://localhost/EnterpriseTester/", "Administrator", "password");
        }

        [Fact]
        public void Search_group_by_entity_type_counts()
        {
            var response = client.Search("GROUP BY EntityType { COUNT }");
            var aggregations = response.Content.ReadAsAsync<JObject>().Result;

            var groups = (JObject) ((JObject) aggregations["Results"])["GroupByEntityType"];

            foreach (var group in groups)
            {
                Console.WriteLine("EntityType: {0}, Count: {1}", group.Key, group.Value["COUNT"].Value<int>());
            }
        }

    }
}