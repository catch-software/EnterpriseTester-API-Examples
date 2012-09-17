REM Example of starting re-index background task for a single project
REM Note: reindex_project.json contains body of request, including
REM unique ID of project.
REM -----------------------------------------------------------------
curl -i -H "Content-Type: application/json" -X POST -d @reindex_project.json -u Administrator:password http://localhost/EnterpriseTester/api/backgroundtasks/