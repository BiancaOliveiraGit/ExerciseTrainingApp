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

                //TODO get clientID from request
                //ClientId = int.Parse(PageContext.HttpContext.Request.Form["ClientId"].ToString());
                ClientId = 1;
            }
            catch (Exception e)
            {
                //TODO
                throw;
            }

        }

        public ActionResult OnPostAddWorkoutClient()
        {
            try
            {
                //get workoutPlanId
                var workoutplanId =  int.Parse(PageContext.HttpContext.Request.Query["Id"].ToString());
                ClientId = int.Parse(PageContext.HttpContext.Request.Form["ClientId"].ToString());                
            }
            catch (Exception e)
            {
                //TODO
                throw;
            }
            return RedirectToPage("ClientWorkouts");
        }
    }
}