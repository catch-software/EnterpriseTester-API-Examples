EnterpriseTester.API.Client
===========================


Introduction
------------

Enterprise Tester Version 4.8 and above support generating a swagger definition for the API, allowing 3rd parties to easily generate clients for the API in their target technology.

As part of this work we have developed a simple API client for .Net (Written in CSharp) which generates all the necessary models and operations from the Swagger JSON produced by the ET v4.8 API.

The API client has a "swagger.json" file in the root, which is copied from the response of a GET request to http://<ET_Server>/api/swagger/api.

Basic Usage
-----------

For simple usage scenarios you can just create an instance of the client, and begin executing methods against it:

	var client = new Client("http://localhost/EnterpriseTester/", "Administrator", "password");
	var packages = client.SearchExecutionPackages(tql: "Name ~ release", top: 10);
	foreach (var package in packages.Items)
	{
		Console.WriteLine("Name: {0}, Id: {1}", package.Name, package.Id);
	}

The client also supports asynchronous execution - so every method has an asynchronous equivalent, so the previous example could look like:

	var client = new Client("http://localhost/EnterpriseTester/", "Administrator", "password");
	var task = client.SearchExecutionPackagesAsync(tql: "Name ~ release", top: 10);
	
	... do some other processing...

	var results = task.Result;

	foreach (var package in packages.Items)
	{
		Console.WriteLine("Name: {0}, Id: {1}", package.Name, package.Id);
	}

Methods that return HttpResponseMessage
---------------------------------------

For API resources that are difficult to represent in swagger (such as search queries, TQL aggregate queries etc.) you may find that the method returns an HttpResponseMessage - this allows you to then deserialized the response any way you like.

Here is an example of retrieving the results of a GROUP BY TQL query:

	var response = client.Search("GROUP BY EntityType { COUNT }");
	var aggregations = response.Content.ReadAsAsync<JObject>().Result;

	var groups = (JObject) ((JObject) aggregations["Results"])["GroupByEntityType"];

	foreach (var group in groups)
	{
	    Console.WriteLine("EntityType: {0}, Count: {1}", group.Key, group.Value["COUNT"].Value<int>());
	}

In the above example we are using the Newtonsoft JSON.Net JObject class, which can represent an JSON response - this is a good way to work with the results of an aggregate query.

Operations
----------

In some cases you may want to make additional changes to a request before it is executed, to do this make use use of the Operations static class to build the operation, and then create and manipulate the request before execution - here is an example of doing that when updating an agile run:

	var client = new Client("http://localhost/EnterpriseTester/", "Administrator", "password");
	var operation = Operations.UpdateAgileRun(id, new CreateOrUpdateAgileRun { Name = "New Name"});
	var request = operation.BuildRequest(_client);
	request.Headers.Add("wait-until-indexed","false");
	var response = _client.SendAsync(request).Result;
	EnsureSuccess(response);

In the above example we are adding a header "wait-until-indexed" with a value of false to the request, this will instruct ET to not block returning from the agile run operation until the indexes have been updated (if for example bulk-inserting data you don't plan to immediately query again).

Releases
--------

A compiled beta version of this API client is available for download from here:

TODO: Insert Link

More info on swagger
--------------------

For more info on swagger please see:

* The http://help.catchsoftware.com/ API feature topics on swagger.
* The https://developers.helloreverb.com/swagger/ homepage.
* Swagger code-gen https://github.com/wordnik/swagger-codegen