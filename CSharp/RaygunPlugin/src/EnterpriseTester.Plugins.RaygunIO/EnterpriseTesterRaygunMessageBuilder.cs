using System;
using System.Collections.Generic;
using System.Web;
using EnterpriseTester.Common.Plugins;
using EnterpriseTester.Core.Models;
using Mindscape.Raygun4Net;
using Mindscape.Raygun4Net.Messages;
using log4net.Core;

namespace EnterpriseTester.Plugins.RaygunIO
{
    public class EnterpriseTesterRaygunMessageBuilder
    {
        readonly IRaygunMessageBuilder _builder;
        readonly Dictionary<string, string> _customData = new Dictionary<string, string>();

        public EnterpriseTesterRaygunMessageBuilder()
        {
            _builder = RaygunMessageBuilder.New
                                           .SetHttpDetails(HttpContext.Current)
                                           .SetEnvironmentDetails()
                                           .SetMachineName(Environment.MachineName)
                                           .SetClientDetails()
                                           .SetVersion();
        }

        public EnterpriseTesterRaygunMessageBuilder SetException(Exception exception)
        {
            _builder.SetExceptionDetails(exception);
            return this;
        }

        public EnterpriseTesterRaygunMessageBuilder SetCustomData(string key, string value)
        {
            _customData[key] = value;
            return this;
        }

        public EnterpriseTesterRaygunMessageBuilder SetUser(User user)
        {
            if (user == null) return this;
            return SetCustomData("User", user.DisplayName).SetCustomData("Email", user.Email);
        }

        public EnterpriseTesterRaygunMessageBuilder SetLicense(LicenseDetails licenseDetails)
        {
            if (licenseDetails == null) return this;

            return SetCustomData("ServerKey", licenseDetails.ServerKey)
                .SetCustomData("Organisation", licenseDetails.Organisation)
                .SetCustomData("LicenseType", licenseDetails.LicenseType)
                .SetCustomData("LicenseKey", licenseDetails.LicenseKey);
        }

        public EnterpriseTesterRaygunMessageBuilder SetLog4NetInfo(LoggingEvent loggingEvent)
        {
            if (loggingEvent == null) return this;

            return SetCustomData("log4net.Level", loggingEvent.Level.ToString())
                .SetCustomData("log4net.Message", loggingEvent.RenderedMessage)
                .SetCustomData("log4net.Repository", loggingEvent.Repository.Name)
                .SetCustomData("log4net.Thread", loggingEvent.ThreadName);
        }

        public RaygunMessage Build()
        {
            if (_customData.Count > 0) _builder.SetUserCustomData(_customData);
            return _builder.Build();
        }
    }
}