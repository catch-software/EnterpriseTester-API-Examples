REM Demonstrates retrieving a project by it's unique ID
REM In this example we also expand Priority and Statuse 
REM picklists for project as well.
REM ----------------------------------------------------

curl -u Administrator:password http://localhost/EnterpriseTester/api/Project/650d8904-c145-4f7c-8b65-a02a0092a85f?$expand=Priorities,Statuses