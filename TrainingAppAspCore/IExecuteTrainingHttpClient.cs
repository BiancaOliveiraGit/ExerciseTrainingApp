using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TrainingAppAspCore
{
    public interface IExecuteTrainingHttpClient 
    {
        HttpClient Client { get; }
        string ReturnedError { get; set; }
        System.Net.HttpStatusCode HttpStatusCode { get; set; }
        Task<T> ExecuteRoute<T>(HttpMethod httpMethod, string uri);
        Task<T> ExecuteRoute<T>(HttpMethod httpMethod, string uri, object bodyDto);
    }
}
