using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
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
        private string Email;

        public ClientWorkoutsModel(IExecuteTrainingHttpClient executeTrainingClient)
        {
            ExecuteHttpClient = executeTrainingClient;
        }

        public async Task OnGet()
        {
            try
            {
                // get ClientID from knowing User.Identities
                var identity = (ClaimsIdentity)User.Identity;
                var claims = identity.Claims;
                Email = claims.Where(e => e.Type == ClaimTypes.NameIdentifier)
                                    .Select(s => s.Value).ToString();

                ClientId = await GetClientId();

                if (ClientId != 0)
                {
                   await GetClientWorkouts();
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

        public async Task<int> GetClientId()
        {
            var HttpClient = ExecuteHttpClient;
            var ClientDto = await HttpClient.ExecuteRoute<ClientDto>(HttpMethod.Get, RouteUri.UriClientByEmail(Email));
            var clientId = ClientDto == null ? 0 : ClientDto.ClientId;
            ClientName = ClientDto != null ? "Hi " + ClientDto.FirstName : "Please Log In";
            return clientId;
        }
    }
}