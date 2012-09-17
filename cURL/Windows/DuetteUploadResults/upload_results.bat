REM Example of uploading an XML file containing automated test
REM results as a new run for an automated test assignment.
REM -----------------------------------------------------------
curl -i --header "Content-Type: multipart/mixed" --form "fileupload=@NUnit.xml;type=text/xml" -u Administrator:password http://localhost/EnterpriseTester/api/automatedtestassignment/857b0d48-38a8-47cf-87cf-a0c9018636a8/runs