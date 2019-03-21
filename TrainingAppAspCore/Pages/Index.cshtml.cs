using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using TrainingAppAspCore.Dto;
using Microsoft.AspNetCore.Authentication.AzureADB2C.UI;

namespace TrainingAppAspCore.Pages
{
    
    public class IndexModel : PageModel
    {
        IExecuteTrainingHttpClient ExecuteHttpClient;


        public IndexModel(IExecuteTrainingHttpClient executeTrainingClient)
        {
            ExecuteHttpClient = executeTrainingClient;
        }
       

    }
}
