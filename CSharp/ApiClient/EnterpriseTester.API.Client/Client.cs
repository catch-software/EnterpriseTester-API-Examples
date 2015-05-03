using System;
using System.Net.Http;
using System.Threading.Tasks;
using EnterpriseTester.API.Client.Models;

namespace EnterpriseTester.API.Client
{
    public partial class Client
    {
        public readonly EnterpriseTesterHttpClient _client;

        public Client(string baseAddress, string username, string password)
            : this(new EnterpriseTesterHttpClient(baseAddress, username, password, true))
        {
        }
        public Client(string baseAddress, string baseAuthString)
            : this(new EnterpriseTesterHttpClient(baseAddress, baseAuthString, true))
        {
        }

        public EnterpriseTesterHttpClient HttpClient
        {
            get { return _client; }
        }

        public Client(EnterpriseTesterHttpClient client)
        {
            if (client == null) throw new ArgumentNullException("client");
            _client = client;
        }

        public virtual void EnsureSuccess(HttpResponseMessage response)
        {
            response.EnsureSuccessStatusCode();
        }
    }
}