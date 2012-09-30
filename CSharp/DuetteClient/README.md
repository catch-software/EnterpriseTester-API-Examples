Duette Command Line Client
==========================

This example demonstrates how to build a command line client for posting automated test results to Enterprise Tester using C# and .Net 4.0.

Though provided as example, this tool will be useful to any customers using Enterprise Tester who want to automatically update test results, say as part of a continuous integration server build process.

Download
--------

You can download a zip file of the DuetteClient from here:

[DuetteClient_v1.0.zip][0]

To install once download, just unzip all the files into a folder, and then invoke "DuetteClient.exe" using the full path to the folder where you unzipped it.

The DuetteClient does not need to be installed on the same machine as Enterprise Tester, but does require that the [Full .Net Framework 4.0 be installed][1].

Usage
-----

	-s/--server required option is missing.


	-s, --server               Required. URL to Enterprise Tester server e.g.
	                         http://localhost/EnterpriseTester

	-u, --username             Required. Username to authenticate to Enterprise
	                         Tester as

	-p, --password             Required. Password to authenticate to Enterprise
	                         Tester as

	-j, --project              Required. The project Name

	-k, --script-package       Required. The script package where the automated
	                         test exists (if package does not exist it will be
	                         created)

	-x, --execution-package    Required. The script package where the automated
	                         test exists (if package does not exist it will be
	                         created)

	-n, --test-name            Required. The name of the automated test (if test
	                         does not exist, it will be created)

	-t, --type                 Required. The type of automated test e.g. QTP,
	                         RFT, Selenium, UnitTest

	-b, --sub-type             Required. The format of results (if using
	                         'UnitTest' type e.g. JUnit, NUnit, MSTest, Gallio,
	                         Cpptest, JSUNit, PHPUnit etc.)

	-c, --save-copy            Save copy of the uploaded zip file to the current
	                         directory (as report.zip)

	--help                     Display this help screen.

Support
-------

This example requires Enterprise Tester version 4.4 and above.

Example Commandline
--------------------

    DuetteClient.exe -s http://localhost/EnterpriseTester -u admin -p password -j "Online Banking" -n "Unit Tests" -t UnitTest -b NUnit -k "Script Library|Automated Tests" -x "Execution Sets|Cycle 1|Automated Tests"  "E:\dev\banking\test1output\*.xml" "E:\dev\banking\test2output\*.xml"

The above example will:

* Connect to the Enterprise Tester server at http://localhost/EnterpriseTester
* Login with username "admin" and password "password"
* Use the project called "Online Banking"
* Create (if it does not exist) an automated test called "Unit Tests", of type "UnitTest" and subtype "NUnit".
* Places the automated test in the script library -> automated tests package (Note: the path is specified using the "package path separator", which defaults to pipe "|" but is configurable via the ET application configuration file).
* Places an automated test assignment in the execution sets -> cycle 1 -> automated tests package (Note: the path is specified using the "package path separator", which defaults to pipe "|" but is configurable via the ET application configuration file).
* Uploads all the NUnit xml output files from the directory test1output and test2output.


[0]: https://github.com/downloads/catch-software/EnterpriseTester-API-Examples/DuetteClient_v1.0.zip
[1]: http://www.microsoft.com/en-us/download/details.aspx?id=17851