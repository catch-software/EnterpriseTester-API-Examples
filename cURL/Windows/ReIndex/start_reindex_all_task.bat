REM Example of starting re-index background task for all projects
REM Note: reindex_all.json contains body of request
REM --------------------------------------------------------------
curl -i -H "Content-Type: application/json" -X POST -d @reindex_all.json -u Administrator:password http://localhost:8092/EnterpriseTester/api/backgroundtasks/