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
    public class WorkoutPlanModel : PageModel
    {
        IExecuteTrainingHttpClient ExecuteHttpClient;
        public List<WorkoutPlanDto> Workouts { get; set; }


        public WorkoutPlanModel(IExecuteTrainingHttpClient executeTrainingClient)
        {
            ExecuteHttpClient = executeTrainingClient;
        }

        public async Task OnGet()
        {
            try
            {
                var Client = ExecuteHttpClient;
                Workouts = await Client.ExecuteRoute<List<WorkoutPlanDto>>(HttpMethod.Get, RouteUri.UriWorkoutPlans);
            }
            catch (Exception e)
            {

                throw;
            }

        }
    }
}