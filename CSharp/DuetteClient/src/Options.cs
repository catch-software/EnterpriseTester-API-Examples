using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

namespace EnterpriseTester.DuetteClient
{
    public class Options : CommandLineOptionsBase
    {
        [Option("s", "server", Required = true, HelpText = "URL to Enterprise Tester server e.g. http://localhost/EnterpriseTester")]
        public string Server { get; set; }

        [Option("u", "username", Required = true, HelpText = "Username to authenticate to Enterprise Tester as")]
        public string UserName { get; set; }

        [Option("p", "password", Required = true, HelpText = "Password to authenticate to Enterprise Tester as")]
        public string Password { get; set; }

        [Option("j", "project", Required = true, HelpText = "The project Name")]
        public string Project { get; set; }

        [Option("k", "script-package", Required = true, HelpText = "The script package where the automated test exists (if package does not exist it will be created)")]
        public string ScriptPackage { get; set; }

        [Option("x", "execution-package", Required = true, HelpText = "The script package where the automated test exists (if package does not exist it will be created)")]
        public string ExecutionPackage { get; set; }

        [Option("n", "test-name", Required = true, HelpText = "The name of the automated test (if test does not exist, it will be created)")]
        public string TestName { get; set; }

        [Option("t", "type", Required = true, HelpText = "The type of automated test e.g. QTP, RFT, Selenium, UnitTest")]
        public string Type { get; set; }

        [Option("b", "sub-type", Required = true, HelpText = "The format of results (if using 'UnitTest' type e.g. JUnit, NUnit, MSTest, Gallio, Cpptest, JSUNit, PHPUnit etc.)")]
        public string SubType { get; set; }

        [Option("c", "save-copy", Required = false, DefaultValue = false, HelpText = "Save copy of the uploaded zip file to the current directory (as report.zip)")]
        public bool SaveCopy { get; set; }

        [ValueList(typeof (List<string>))]
        public IList<string> ResultFiles { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}