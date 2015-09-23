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
        private readonly Client client;

        public AgileRunTests()
        {
            client = new Client("http://localhost:8092/EnterpriseTester/", "Administrator", "password");
        }

        private string GetSingleExecutionPackageId()
        {
            return client.SearchExecutionPackages(top: 1).Items.Single().Id;
        }

        [Fact]
        public void create_agile_run()
        {
            string packageId = GetSingleExecutionPackageId();

            AgileRun run = client.CreateAgileRun(new CreateOrUpdateAgileRun { PackageId = packageId, Name = "My Agile Run" });

            Assert.Equal("My Agile Run", run.Name);
            Assert.NotEqual(Guid.Empty.ToString(), run.Id);
        }

        [Fact]
        public void update_agile_run()
        {
            string packageId = GetSingleExecutionPackageId();

            AgileRun run = client.CreateAgileRun(new CreateOrUpdateAgileRun { PackageId = packageId, Name = "My Agile Run" });

            AgileRun updatedRun = client.UpdateAgileRun(run.Id, new CreateOrUpdateAgileRun { Name = "Updated name" });

            Assert.Equal("Updated name", updatedRun.Name);
        }

        [Fact]
        public void delete_agile_run_then_do_get_for_deleted_run_returns404()
        {
            string packageId = GetSingleExecutionPackageId();

            AgileRun run = client.CreateAgileRun(new CreateOrUpdateAgileRun { PackageId = packageId, Name = "My Agile Run" });

            client.DeleteAgileRun(run.Id);

            Assert.Throws<HttpRequestException>(() => client.GetAgileRun(run.Id));
        }

        [Fact]
        public void search_agile_runs_async()
        {
            var runsTask = client.SearchAgileRunsAsync("Text ~ 'Release'", top: 100);
            var result = runsTask.Result;
            Assert.Equal(100, result.Top);
        }

        [Fact]
        public void create_faulty_agile_run()
        {
            try
            {
                client.CreateAgileRun(new CreateOrUpdateAgileRun {Name = "My Agile Run"});
                throw new AssertException("Exception doe not thrown!");
            }
            catch (HttpRequestException e)
            {
                Assert.Equal("System.Net.Http.HttpRequestException status code does not indicate success: 403 (Forbidden).\n{\r\n  \"Message\": \"You must specify a valid PackageId which the agile run can be added to.\"\r\n}", e.Message);
            }

        }
    }
}