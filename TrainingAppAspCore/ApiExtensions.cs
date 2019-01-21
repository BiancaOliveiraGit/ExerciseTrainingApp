using Newtonsoft.Json;
using System.Net.Http;
using System.Text;


public static class ApiExtensions
    {
        public static void SetJsonContent(this HttpRequestMessage httpRequestMessage, object data)
        {
            var dt = JsonConvert.SerializeObject(data);

            HttpContent contentPost = new StringContent(dt, Encoding.UTF8, "application/json");
            httpRequestMessage.Content = contentPost;
        }
    }

