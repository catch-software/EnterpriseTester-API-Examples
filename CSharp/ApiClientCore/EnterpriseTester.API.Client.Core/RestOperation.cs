using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net.Http;
//using System.Web;

namespace EnterpriseTester.API.Client.Core
{
    public class RestOperation
    {
        public RestOperation(string method, string path)
        {
            Method = method;
            Path = path;
            QueryParams = new Dictionary<string, object>();
            FormParams = new Dictionary<string, object>();
        }

        public object Content { get; set; }

        public string Method { get; private set; }

        public Dictionary<string, object> QueryParams { get; private set; }

        public Dictionary<string, object> FormParams { get; private set; }

        public string Path { get; private set; }

        /// <summary>
        ///     OData or TQL $skip
        /// </summary>
        public int? Skip
        {
            get { return GetValue<int?>("$skip"); }
            set { SetValue("$skip", value); }
        }

        /// <summary>
        ///     OData or TQL $top
        /// </summary>
        public int? Top
        {
            get { return GetValue<int?>("$top"); }
            set { SetValue("$top", value); }
        }

        /// <summary>
        ///     OData $orderby
        /// </summary>
        public string OrderBy
        {
            get { return GetValue<string>("$orderby"); }
            set { SetValue("$orderby", value); }
        }

        /// <summary>
        ///     OData $filter
        /// </summary>
        public string Filter
        {
            get { return GetValue<string>("$orderby"); }
            set { SetValue("$orderby", value); }
        }

        /// <summary>
        ///     OData or TQL $inlinecount
        /// </summary>
        public bool InlineCount
        {
            get { return "allpages" == GetValue<string>("$inlinecount"); }
            set
            {
                if (value) SetValue("$inlinecount", "allpages");
                else SetValue("$inlinecount", (string) null);
            }
        }

        /// <summary>
        ///     OData or TQL $expands
        /// </summary>
        public string Expands
        {
            get { return GetValue<string>("$expands"); }
            set
            {
                QueryParams = QueryParams ?? new Dictionary<string, object>();

                object v;

                QueryParams.TryGetValue("expand", out v);

                string expands = (v ?? "").ToString();

                if (string.IsNullOrWhiteSpace(expands))
                {
                    expands = value;
                }
                else
                {
                    expands = expands + "," + value;
                }

                QueryParams["expand"] = expands;
            }
        }

        /// <summary>
        ///     set OData $expand (chained)
        /// </summary>
        /// <param name="expand"></param>
        /// <returns></returns>
        public RestOperation Expand(string expand)
        {
            Expands = expand;
            return this;
        }

        /// <summary>
        ///     Set OData $skip and $take (chained)
        /// </summary>
        /// <param name="top"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        public RestOperation Page(int? top = null, int? skip = null)
        {
            Skip = skip ?? Skip;
            Top = top ?? Top;
            return this;
        }

        private void SetValue<T>(string key, T value)
        {
            if (Method == "GET" || Method == "DELETE")
            {
                QueryParams = QueryParams ?? new Dictionary<string, object>();

                QueryParams[key] = value;

                return;
            }

            FormParams = FormParams ?? new Dictionary<string, object>();

            FormParams[key] = value;
        }

        private T GetValue<T>(string key)
        {
            object value;

            if (Method == "GET" || Method == "DELETE")
            {
                QueryParams = QueryParams ?? new Dictionary<string, object>();

                if (QueryParams.TryGetValue(key, out value))
                {
                    return (T) value;
                }

                return default(T);
            }

            FormParams = FormParams ?? new Dictionary<string, object>();

            if (FormParams.TryGetValue(key, out value))
            {
                return (T) value;
            }

            return default(T);
        }

        public HttpRequestMessage BuildRequest(EnterpriseTesterHttpClient client)
        {
            string url = Path;

            if (QueryParams.Count > 0)
            {
               // NameValueCollection queryParameters = HttpUtility.ParseQueryString("");
                var queryParameters = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery("");

                foreach (var kvp in QueryParams)
                {
                    if (kvp.Value == null) continue;
                    queryParameters[kvp.Key] = kvp.Value.ToString();
                }

                string urlParamaters = "";

                foreach (var entry in queryParameters)
                {
                    urlParamaters += "&" + entry.Key + "=" + entry.Value;
                }

                url += "?" + urlParamaters.Remove(0, 1);
               // url += "?" + queryParameters;
            }

            var request = new HttpRequestMessage(new HttpMethod(Method), url);

            if (Content != null)
            {
                request.Content = client.CreateContent(Content);
            }
            else if (FormParams.Count > 0)
            {
                request.Content =
                    new FormUrlEncodedContent(
                        FormParams.Select(
                            kvp =>
                            new KeyValuePair<string, string>(kvp.Key, kvp.Value == null ? null : kvp.Value.ToString())));
            }

            return request;
        }
    }
}