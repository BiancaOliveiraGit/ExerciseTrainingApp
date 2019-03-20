using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
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
        private string ClientObjectIdentifier;

        public ClientWorkoutsModel(IExecuteTrainingHttpClient executeTrainingClient)
        {
            ExecuteHttpClient = executeTrainingClient;
        }

        public async Task OnGet()
        {
            try
            {
                ClientWorkouts = new List<ClientWorkoutDto>();
                // get ClientObjectIdentifier from knowing User.Identities
                var identity = (ClaimsIdentity)User.Identity;
                var claims = identity.Claims;
                ClientObjectIdentifier = claims.Where(e => e.Type == ClaimTypes.NameIdentifier)
                                    .Select(s => s.Value).First();

                ClientId = await GetClient(ClientObjectIdentifier);

                //first time login so create entry into database
                if (ClientId == 0 && !string.IsNullOrEmpty(ClientObjectIdentifier))
                {
                    //add client to database
                    var name = claims.Where(e => e.Type == "name").Select(s => s.Value).First();
                    var email = claims.Where(e => e.Type == "emails").Select(s => s.Value).First();

                    var newClient = new ClientDto()
                    {
                        FirstName = name,
                        Email = email,
                        ObjectIdentifier = ClientObjectIdentifier,
                    };
                    var clientDto = await PostClient(newClient);

                    ClientId = clientDto.ClientId;
                }

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

        public async Task<int> GetClient(string clientObjectIdentifier)
        {
            var HttpClient = ExecuteHttpClient;
            ClientDto clientQuery = new ClientDto()
            {
                ObjectIdentifier = clientObjectIdentifier,
            };
            var ClientDto = await HttpClient.ExecuteRoute<ClientDto>(HttpMethod.Post, RouteUri.UriClientQuery, clientQuery);
            var clientId = ClientDto == null ? 0 : ClientDto.ClientId;
            ClientName = ClientDto != null ? "Hi " + ClientDto.FirstName : "Please Log In";
            return clientId;
        }

        public async Task<ClientDto> PostClient(ClientDto newClient)
        {
            var HttpClient = ExecuteHttpClient;

            var ClientDto = await HttpClient.ExecuteRoute<ClientDto>(HttpMethod.Post, RouteUri.UriClients, newClient);
            ClientId = ClientDto == null ? 0 : ClientDto.ClientId;
            if(ClientId == 0)
            {
                ClientDto = new ClientDto();
            }
            return ClientDto;
        }
    }
}