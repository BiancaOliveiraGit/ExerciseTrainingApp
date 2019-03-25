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
    public class CreateWorkoutModel : PageModel
    {
        IExecuteTrainingHttpClient ExecuteHttpClient;
        public List<WorkoutPlanDto> Workouts { get; set; }
        public int ClientId { get; set; }
        public string ErrorMessage { get; set; }

        public CreateWorkoutModel(IExecuteTrainingHttpClient executeTrainingClient)
        {
            ExecuteHttpClient = executeTrainingClient;
        }

        public async Task OnGet()
        {
            try
            {
               var Client = ExecuteHttpClient;
               Workouts = await Client.ExecuteRoute<List<WorkoutPlanDto>>(HttpMethod.Get, RouteUri.UriWorkoutPlans);

                //clientID from cookie
                ClientId = int.Parse(HttpContext.Request.Cookies["ClientId"]);
            }
            catch (Exception e)
            {
                //TODO error logging
                throw;
            }

        }
        public async Task OnGetModal()
        {
            try
            {
                var Client = ExecuteHttpClient;
                Workouts = await Client.ExecuteRoute<List<WorkoutPlanDto>>(HttpMethod.Get, RouteUri.UriWorkoutPlans);

                ClientId = int.Parse(HttpContext.Request.Cookies["ClientId"].ToString());
                ErrorMessage = TempData["ErrorMessage"].ToString();
            }
            catch (Exception e)
            {
                //TODO log error
                throw;
            }

        }

        public async Task<ActionResult> OnPostAddWorkoutClient() 
        {
            try
            {
                //get workoutPlanId & clientId
                var workoutplanId =  int.Parse(PageContext.HttpContext.Request.Query["Id"].ToString());
                ClientId = int.Parse(HttpContext.Request.Cookies["ClientId"]);
                var frequency = int.Parse(HttpContext.Request.Form["frequency"]);

                //create dto to post
                AddClientWorkoutDto addClientWorkoutDto = new AddClientWorkoutDto()
                {
                    ClientId = ClientId,
                    Frequency = frequency,
                    WorkoutPlanId = workoutplanId,
                };

                var Client = ExecuteHttpClient;
                var clientWorkouts = await Client.ExecuteRoute<ClientWorkoutDto>(HttpMethod.Post, RouteUri.UriClientWorkouts,addClientWorkoutDto);

                if(Client.HttpStatusCode != System.Net.HttpStatusCode.OK)
                {
                    //error with Post                
                    ErrorMessage = Client.ReturnedError;
                    TempData["ErrorMessage"] = ErrorMessage;
                    return RedirectToPage("CreateWorkout","Modal");
                    //TODO redirect to error page or error popup
                }
                else
                {
                    return RedirectToPage("ClientWorkouts");
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}