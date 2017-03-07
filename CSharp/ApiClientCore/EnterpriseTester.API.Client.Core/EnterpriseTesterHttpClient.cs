using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace EnterpriseTester.API.Client.Core
{
    public class EnterpriseTesterHttpClient : HttpClient
    {
        public static readonly JsonSerializer Serializer = new JsonSerializer();

        public EnterpriseTesterHttpClient(string baseAddress, string username, string password, bool followRedirects)
            : base(new HttpClientHandler {AllowAutoRedirect = followRedirects})
        {
            ConfigureBasicAuth(baseAddress, username, password);
        }

        public EnterpriseTesterHttpClient(string baseAddress, string baseAuthString, bool followRedirects)
            : base(new HttpClientHandler
            {
                AllowAutoRedirect = followRedirects
            })
        {
            ConfigureBasicAuth(baseAddress, baseAuthString);
        }

        public EnterpriseTesterHttpClient(HttpMessageHandler handler, string baseAddress, string username,
                                          string password)
            : base(handler)
        {
            ConfigureBasicAuth(baseAddress, username, password);
        }

        public EnterpriseTesterHttpClient(string baseAddress, string username, string password)
        {
            ConfigureBasicAuth(baseAddress, username, password);
        }

        private void ConfigureBasicAuth(string baseAddress, string username, string password)
        {
            string auth = Convert.ToBase64String(Encoding.ASCII.GetBytes(username + ":" + password));
            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", auth);
            BaseAddress = new Uri(baseAddress);
        }

        // EnterpriseTester.API.Client.EnterpriseTesterHttpClient
        private void ConfigureBasicAuth(string baseAddress, string hash)
        {
            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", hash);
            BaseAddress = new Uri(baseAddress);
        }


        public HttpContent CreateContent<T>(T o)
        {
            var stringWriter = new StringWriter();
            Serializer.Serialize(new JsonTextWriter(stringWriter) {Formatting = Formatting.Indented}, o);
            return new StringContent(stringWriter.ToString(), Encoding.UTF8, "application/json");
        }
    }
}