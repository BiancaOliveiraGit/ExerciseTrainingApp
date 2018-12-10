using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using TrainingAppAspCore.Dto;

namespace TrainingAppAspCore.Pages
{
    
    public class IndexModel : PageModel
    {
        IExecuteTrainingHttpClient ExecuteHttpClient;
        public List<ClientDto> Values { get; set; }


        public IndexModel(IExecuteTrainingHttpClient executeTrainingClient)
        {
            ExecuteHttpClient = executeTrainingClient;
        }
       
        public async Task OnGet()
        {
            try
            {
                var Client = ExecuteHttpClient;
                Values = await Client.ExecuteRoute<List<ClientDto>>(HttpMethod.Get,RouteUri.UriClients);
            }
            catch (Exception e)
            {

                throw;
            }
 
        }
    }
}
