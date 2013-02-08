using System;
using EnterpriseTester.Common.Facilities.AppSettingsParam;
using Mindscape.Raygun4Net;

namespace EnterpriseTester.Plugins.RaygunIO
{
    public class RaygunClientExecutor
    {
        readonly string _apiKey;
        readonly bool _enabled;

        public RaygunClientExecutor([AppSettingsParam(Key = "raygunio.apiKey", Default = "")] string apiKey)
        {
            _apiKey = apiKey;
            _enabled = !string.IsNullOrWhiteSpace(apiKey);
        }

        public void Execute(Action<RaygunClient> callback)
        {
            if (_enabled)
            {
                var client = new RaygunClient(_apiKey);
                callback(client);
            }
        }
    }
}