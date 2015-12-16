using System;
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
        private readonly Client _client;

        public SearchTests()
        {
            _client = new Client("http://localhost:8092/EnterpriseTester/", "Administrator", "password");
        }

        [Fact]
        public void Search_group_by_entity_type_counts()
        {
            var response = _client.Search("GROUP BY EntityType { COUNT }");
            var aggregations = response.Content.ReadAsAsync<JObject>().Result;

            var groups = (JObject) ((JObject) aggregations["Results"])["GroupByEntityType"];

            foreach (var group in groups)
            {
                Console.WriteLine("EntityType: {0}, Count: {1}", group.Key, group.Value["COUNT"].Value<int>());
            }
        }

    }
}