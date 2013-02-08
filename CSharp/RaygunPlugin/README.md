Raygun Plugin
=============

This is an example of a simple .Net plugin for Enterprise Tester that demonstrates integrating with both the log4net and the unhandled exception pub/sub events of Enterprise Tester.

It takes the exception events and publishes the information to Raygun, a service provided by Mindscape that allows for the monitoring and tracking of exceptions.

You can find more information about Raygun from mindscape [on their website][0]

Deployment
-----------

To deploy this plugin you must build it, and then copy the following assemblies into the \Web\bin\ folder of your Enterprise Tester installation:

* Mindscape.Raygun4Net.dll
* EnterpriseTester.Plugins.RaygunIO.dll

Once complete you must then edit your web.config file, and add the following appSetting entry:

    <appSettings>
      ..
      <add key="raygunio.apiKey" value="{{ your api key }}" />

From then on, any exceptions which occur in Enterprise Tester will be automatically logged to Raygun, so you can be notified as issues occur in your Enterprise Tester installation.

Compatibility
-------------

This plugin is compatible with Enterprise Tester version 4.6 and above (though it could also be easily be back-ported to work with version 4.5 and below of Enterprise Tester, by removing the 'UnahandledExceptionRaygunRelayer' class and registration code.)

Custom Data
-----------

This plugin captures the following custom data for each event, if available:

* Basic license details (license type, server key, license key)
* User associated with request (username, fullname and email address).
* For log4net logging events - the log level, repository and log message are recorded.

  [0]: http://raygun.io