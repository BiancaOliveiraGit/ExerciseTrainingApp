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
        public string ReturnedError { get; set; }
        public System.Net.HttpStatusCode HttpStatusCode { get; set; }
        public ExecuteTrainingHttpClient(IHttpClientFactory httpClientFactory)
        {
            Client = httpClientFactory.CreateClient("training");
        }

        public async Task<T> ExecuteRoute<T>(HttpMethod httpMethod, string uri)
        {
            var response = await Client.SendAsync(new HttpRequestMessage(httpMethod,uri));
            HttpStatusCode = response.StatusCode;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsAsync<T>();
            }
            else
            {
                //bad response
                ReturnedError = await response.Content.ReadAsAsync<string>();
                var emptyObject = new object();
                return (T)emptyObject;
            }
        }

        public async Task<T> ExecuteRoute<T>(HttpMethod httpMethod, string uri, object bodyDto)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, uri);
            httpRequestMessage.SetJsonContent(bodyDto);

            var response = await Client.SendAsync(httpRequestMessage);
            HttpStatusCode = response.StatusCode;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsAsync<T>();
            }
            else
            {
                //bad response
                ReturnedError = await response.Content.ReadAsAsync<string>();
                var emptyObject = new object();
                return (T)emptyObject;
            }
            
        }
    }
}
