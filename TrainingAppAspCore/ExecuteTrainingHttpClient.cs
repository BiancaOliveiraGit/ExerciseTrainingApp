using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TrainingAppAspCore
{
    public class ExecuteTrainingHttpClient : HttpClient, IExecuteTrainingHttpClient
    {
        public HttpClient Client { get; }
        public ExecuteTrainingHttpClient(IHttpClientFactory httpClientFactory)
        {
            Client = httpClientFactory.CreateClient("training");
        }

        public async Task<T> ExecuteRoute<T>(HttpMethod httpMethod, string uri)
        {
            var response = await Client.SendAsync(new HttpRequestMessage(httpMethod,uri));
            var content = await response.Content.ReadAsAsync<T>();
            return content;
        }

    }
}
