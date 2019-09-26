using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;

namespace MMKiwi.CloudflareDDNS.CloudflareApi
{
    public class ApiBase
    {
        static HttpClient? _client;
        static HttpClient Client
        {
            get
            {
                if (_client == null) _client = new HttpClient(); return _client;
            }
        }
        readonly string _apiToken;

        public ApiBase(string ApiToken)
        {
            _apiToken = ApiToken;
            Client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
            Client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _apiToken);
        }

        public ApiBase(IConfigurationRoot appConfig) : this(appConfig?.GetSection("CloudflareApi")["ApiToken"] ?? "")
        {
        }

        public Response<TRes> SendRequest<TRes>(string endPoint, HttpMethod method, string content = null)
        {
            var request = new HttpRequestMessage(method, "https://api.cloudflare.com/client/v4/" + endPoint);
            if (content != null) request.Content = new StringContent(content);
            HttpResponseMessage response = Client.SendAsync(request).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<Response<TRes>>(result);
            }
            else
            {
                return new Response<TRes>
                {
                    Errors = new string[] { response.StatusCode.ToString() }
                };
            }
        }

        public IEnumerable<Zone>? Zones
        {
            get
            {
                var response = SendRequest<Zone>("zones", HttpMethod.Get);
                return response.Result;
            }
        }
    }
}
