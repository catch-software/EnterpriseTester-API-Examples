using System;
using System.Linq;
using System.Net.Http;
using EnterpriseTester.API.Client.Models;
using Xunit;

namespace EnterpriseTester.API.Client.Tests
{
    /// <summary>
    /// Example demonstrating creating, updating, retrieving and delete agile runs.
    /// </summary>
    public class TestScriptTests
    {
        private readonly Client client;

        public TestScriptTests()
        {
            client = new Client("http://localhost:8092/EnterpriseTester/", "Administrator", "***REMOVED***");
        }

        [Fact]
        public void SearchScriptsDoesNotThrows()
        {
            Assert.DoesNotThrow(() => client.SearchScripts());
        }

    }
}