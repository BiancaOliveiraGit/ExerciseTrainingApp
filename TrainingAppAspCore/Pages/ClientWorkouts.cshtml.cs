using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrainingAppAspCore.Dto;

namespace TrainingAppAspCore.Pages
{
    public class ClientWorkoutsModel : PageModel
    {
        public string ClientName { get; set; }
        public int ClientId { get; set; }
        IExecuteTrainingHttpClient ExecuteHttpClient;
        public List<ClientWorkoutDto> ClientWorkouts { get; set; }


        public ClientWorkoutsModel(IExecuteTrainingHttpClient executeTrainingClient)
        {
            ExecuteHttpClient = executeTrainingClient;
        }

        public async Task OnGet()
        {
            try
            {
                if (ClientId != 0)
                {
                   GetClientWorkouts();
                }
            }
            catch (Exception e)
            {

                throw;
            }

        }

        public async Task<Boolean> GetClientWorkouts()
        {
            var HttpClient = ExecuteHttpClient;
            ClientWorkouts = await HttpClient.ExecuteRoute<List<ClientWorkoutDto>>(HttpMethod.Get, RouteUri.UriClientWorkoutsById(ClientId));
            var ClientDto = await HttpClient.ExecuteRoute<ClientDto>(HttpMethod.Get, RouteUri.UriClientById(ClientId));
            ClientName = ClientDto != null ? "Hi " + ClientDto.FirstName : "Please Log In";
            return true;
        }

    }
}