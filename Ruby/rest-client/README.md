Using rest-client with Enterprise Tester API
============================================

The rest-client is a library (DSL) that makes it easy to work with RESTful API's within Ruby.  You can find out more about the rest-client on [the projects website][0]

Installing
---------------

First thing to do is install the rest-client gem:

    gem install rest-client


Next pull up an instance of Enterprise Tester and access the online help, you will need to refer to the API documentation frequently to understand what resources are available to work with.

The online help can also be accessed in a form which you can bookmark from [http://dev.enterprisetester.com/help/#API][1]

Additionally you may find it useful to have the chrome browser and the advanced rest client available for testing.  See [this blog post for more details on using the advanced rest client][2].

You are now ready to start interacting with the Enterprise Tester API.

Getting started
----------------

For any code interacting with the rest client you will want to do the following:

    require 'rest_client'

Additionally you may also want to do this:

    require 'json'

This will give you access to the useful methods such as to_json.

Next you will want to create a RestClient resource pointing at the root API for Enterprise Tester:

    site = RestClient::Resource.new('http://username:password@myserver/EnterpriseTester/api/')

Notice we pass in the login and password colon separated, followed by the address of the server, including path to the /api resource.
 
You are then able to use site with an array subscript to select the resource you want to interact with e.g.

site['search'].get ...

Would point the url http://username:password@localhost/EnterpriseTester/api/search

And would be the same as:

RestClient.get 'http://username:password@localhost/EnterpriseTester/api/search', ...

Saving some repetative typing/string concatenation.

Note: because the basic-auth username and password are embedded in the url, you may want to using string interpolation to inject the username, password and base url values in from a configuration file to avoid embedding them into source code which might be comitted into source code repo.

Example: PUT script run
-----------------------

In this example we are going to demonstrate using 'PUT' to update the custom field values for a script run.

In our example we have a "textarea" custom field called 'AdditionalNotes' that we are going to update, and our script run has an Id of '2cd6f2e7-df0d-4aa8-9e48-a14d00851623'.

Note: even for complete runs, custom fields and the actual duration values can be updated, but the outcome of step results etc. can not be modified once a run is complete.

    require 'rest_client'
    require 'json'
    
    site = RestClient::Resource.new('http://username:password@localhost/EnterpriseTester/api/')
    
    runId = '2cd6f2e7-df0d-4aa8-9e48-a14d00851623'
    
    response = site['scriptrun/'+runId+'?$expand=FieldValues'].put ({ 'FieldValues' => { 'AdditionalNotes' => 'Here are some additional notes' } }).to_json, :content_type => :json, :accept => :json

In the above example response has the following properties:

* response.code => returns the status code, in the above example this should be 200 OK if it was successful.
* response.cookies => returns a hash of the cookie key/value pairs
* response.headers => returns a hash of the header key/value pairs
* response.to_str => returns the body of the response as a string

If we were to:

    print response.to_str

We would see this:

    {"Id":"2cd6f2e7-df0d-4aa8-9e48-a14d00851623","ActualDuration":"5 minutes","Scrip
    tId":"f7b2ffbb-4634-4c26-ba12-a14d00851374","ScriptVersion":1,"AssignmentId":"f7
    b2ffbb-4634-4c26-ba12-a14d00851374","CreatedAt":"2013-01-20T19:04:33Z","LastUpda
    tedAt":"2013-01-20T19:04:44Z","CreatedById":"e7cdbf2b-555b-4afb-a57b-a14300fad97
    8","CreatedBy":"Administrator","RunById":"e7cdbf2b-555b-4afb-a57b-a14300fad978",
    "RunBy":"Administrator","LastUpdatedById":"e7cdbf2b-555b-4afb-a57b-a14300fad978"
    ,"LastUpdatedBy":"Administrator","Status":"Failed","Completed":true,"Expands":["
    Assignment","FieldControls","StepResults"],"FieldValues":{"Note":"Some notes","A
    dditionalNotes":"Here are some additional notes"},"Self":"http://localhost:8092/
    EnterpriseTester/api/scriptrun/2cd6f2e7-df0d-4aa8-9e48-a14d00851623"}

This is the JSON response returned from the server, by default the output is not nicely formatted (to save on payload size), but if you re-executed the request with the additional indent-json query string parameter (can also be passed as a header):

    response = site['scriptrun/'+runId+'?$expand=FieldValues&indent-json=true'].put ({ 'FieldValues' => { 'AdditionalNotes' => 'Here are some additional notes' } }).to_json, :content_type => :json, :accept => :json

Then you would get back this when printing response.to_str:

    {
    "Id": "2cd6f2e7-df0d-4aa8-9e48-a14d00851623",
    "ActualDuration": "5 minutes",
    "ScriptId": "f7b2ffbb-4634-4c26-ba12-a14d00851374",
    "ScriptVersion": 1,
    "AssignmentId": "f7b2ffbb-4634-4c26-ba12-a14d00851374",
    "CreatedAt": "2013-01-20T19:04:33Z",
    "LastUpdatedAt": "2013-01-20T19:04:44Z",
    "CreatedById": "e7cdbf2b-555b-4afb-a57b-a14300fad978",
    "CreatedBy": "Administrator",
    "RunById": "e7cdbf2b-555b-4afb-a57b-a14300fad978",
    "RunBy": "Administrator",
    "LastUpdatedById": "e7cdbf2b-555b-4afb-a57b-a14300fad978",
    "LastUpdatedBy": "Administrator",
    "Status": "Failed",
    "Completed": true,
    "Expands": [
      "Assignment",
      "FieldControls",
      "StepResults"
    ],
    "FieldValues": {      
      "AdditionalNotes": "Here are some additional notes"
    },
    "Self": "http://localhost/EnterpriseTester/api/scriptrun/2cd6f2e7-df0d-4aa8-9e48-a14d00851623"
    }

So as you can see, our "AdditionalNotes" change in our request has been applied to the entity and is reflected in the copy of the entity we get back in the response.

[0]: https://github.com/archiloque/rest-client
[1]: http://dev.enterprisetester.com/help/#API
[2]: http://blog.bittercoder.com/2012/09/14/demonstrating-a-rest-api/
