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
    public class StartExerciseModel : PageModel
    {
        IExecuteTrainingHttpClient ExecuteHttpClient;
        public List<ExerciseDto> Exercises { get; set; }
        public int ClientId { get; set; }
        public int WorkoutPlanId { get; set; }
        public string ErrorMessage { get; set; }

        public StartExerciseModel(IExecuteTrainingHttpClient executeTrainingClient)
        {
            ExecuteHttpClient = executeTrainingClient;
        }

        public async Task OnGet()
        {
            try
            {
               //get workoutplanID from request
               WorkoutPlanId = int.Parse(HttpContext.Request.Query["Id"]);

               var Client = ExecuteHttpClient;
               var workoutExercise = await Client.ExecuteRoute<List<WorkoutExerciseDto>>(HttpMethod.Get, RouteUri.UriWorkoutExercises);

                Exercises = workoutExercise.Where(w => w.WorkoutPlanId == WorkoutPlanId)
                              .Select(s => s.Exercise).ToList();
               
                ClientId = int.Parse(HttpContext.Request.Cookies["ClientId"]);

                //TODO get reps & weight for each exercise - probs best do in api
            }
            catch (Exception e)
            {
                //TODO log error
                throw;
            }

        }
       
    }
}