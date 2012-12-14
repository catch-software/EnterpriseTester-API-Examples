using CommandLine;
using CommandLine.Text;

namespace RelationshipCreator
{
    public class Options : CommandLineOptionsBase
    {
        [Option("s", "server", Required = true, HelpText = "URL to Enterprise Tester server e.g. http://localhost/EnterpriseTester")]
        public string Server { get; set; }

        [Option("u", "username", Required = true, HelpText = "Username to authenticate to Enterprise Tester as")]
        public string UserName { get; set; }

        [Option("p", "password", Required = true, HelpText = "Password to authenticate to Enterprise Tester as")]
        public string Password { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}