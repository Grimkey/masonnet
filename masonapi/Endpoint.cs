using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Mason.API
{
    public class Endpoint 
    {
        private const string DefaultUrl = "https://api.bymason.com/v1/";

        public Endpoint(string apitoken, string baseAddress = null)
        {
           this.Client = new HttpClient {BaseAddress = new Uri(baseAddress ?? DefaultUrl)};
           this.Client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("basic", apitoken);
           this.Client.DefaultRequestHeaders.Accept
               .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public HttpClient Client { get; }
    }
}