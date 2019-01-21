using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TrainingAppAspCore.Dto;

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

        public async Task<T> ExecuteRoute<T>(HttpMethod httpMethod, string uri) where T : new()
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
                var errorObject = await response.Content.ReadAsAsync<ErrorDetailsDto>();
                ReturnedError = errorObject.Message;
                return new T();
            }
        }

        public async Task<T> ExecuteRoute<T>(HttpMethod httpMethod, string uri, object bodyDto) where T:new()
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
                var errorObject = await response.Content.ReadAsAsync<ErrorDetailsDto>();
                ReturnedError = errorObject.Message;
                return new T();
            }
            
        }
    }
}
