using System;
using System.Linq;
using System.Net.Http;
using EnterpriseTester.API.Client.Models;
using Xunit;
using Xunit.Sdk;

namespace EnterpriseTester.API.Client.Tests
{
    /// <summary>
    /// Example demonstrating creating, updating, retrieving and delete agile runs.
    /// </summary>
    public class AgileRunTests
    {
        private readonly Client _client;

        public AgileRunTests()
        {
            _client = new Client("http://localhost:8092/EnterpriseTester/", "administrator", "password");
        }

        private string GetSingleExecutionPackageId()
        {
	        var items = _client.SearchExecutionPackages(top: 1).Items;
            return items.Single().Id;
        }

        [Fact]
        public void create_agile_run()
        {
            string packageId = GetSingleExecutionPackageId();

            AgileRun run = _client.CreateAgileRun(new CreateOrUpdateAgileRun { PackageId = packageId, Name = "My Agile Run" });

            Assert.Equal("My Agile Run", run.Name);
            Assert.NotEqual(Guid.Empty.ToString(), run.Id);
        }

        [Fact]
        public void update_agile_run()
        {
            string packageId = GetSingleExecutionPackageId();

            AgileRun run = _client.CreateAgileRun(new CreateOrUpdateAgileRun { PackageId = packageId, Name = "My Agile Run" });

            AgileRun updatedRun = _client.UpdateAgileRun(run.Id, new CreateOrUpdateAgileRun { Name = "Updated name" });

            Assert.Equal("Updated name", updatedRun.Name);
        }

        [Fact]
        public void delete_agile_run_then_do_get_for_deleted_run_returns404()
        {
            string packageId = GetSingleExecutionPackageId();

            AgileRun run = _client.CreateAgileRun(new CreateOrUpdateAgileRun { PackageId = packageId, Name = "My Agile Run" });

            _client.DeleteAgileRun(run.Id);

            Assert.Throws<HttpRequestException>(() => _client.GetAgileRun(run.Id));
        }

        [Fact]
        public void search_agile_runs_async()
        {
            var runsTask = _client.SearchAgileRunsAsync("Text ~ 'Release'", top: 100);
            var result = runsTask.Result;
            Assert.Equal(100, result.Top);
        }

        [Fact]
        public void create_faulty_agile_run()
        {
            try
            {
                _client.CreateAgileRun(new CreateOrUpdateAgileRun {Name = "My Agile Run"});
                throw new AssertException("Exception doe not thrown!");
            }
            catch (HttpRequestException e)
            {
                Assert.Equal("System.Net.Http.HttpRequestException status code does not indicate success: 403 (Forbidden).\n{\r\n  \"Message\": \"You must specify a valid PackageId which the agile run can be added to.\"\r\n}", e.Message);
            }

        }
    }
}