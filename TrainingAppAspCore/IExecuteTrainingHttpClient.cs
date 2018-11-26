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
        Task<T> GetRoute<T>(string uri);
    }
}
