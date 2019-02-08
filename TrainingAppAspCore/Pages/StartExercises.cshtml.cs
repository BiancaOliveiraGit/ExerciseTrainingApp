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
                //TODO get workoutplanID from request
                WorkoutPlanId = 4;

                var Client = ExecuteHttpClient;
               var workoutExercise = await Client.ExecuteRoute<List<WorkoutExerciseDto>>(HttpMethod.Get, RouteUri.UriWorkoutExercises);

                Exercises = workoutExercise.Where(w => w.WorkoutPlanId == WorkoutPlanId)
                              .Select(s => s.Exercise).ToList();

                //TODO get clientID from request
                //ClientId = int.Parse(PageContext.HttpContext.Request.Form["ClientId"].ToString());
                ClientId = 1;

                //TODO get reps & weight for each exercise - probs best do in api
            }
            catch (Exception e)
            {
                //TODO
                throw;
            }

        }
       

        //public async Task<ActionResult> OnPostAddWorkoutClient(int frequency) 
        //{
        //    try
        //    {
        //        //get workoutPlanId & clientId
        //        var workoutplanId =  int.Parse(PageContext.HttpContext.Request.Query["Id"].ToString());
        //        ClientId = int.Parse(PageContext.HttpContext.Request.Form["ClientId"].ToString());
        //        // var frequency = int.Parse(PageContext.HttpContext.Request.Form["ClientId"].ToString());
        //        //create dto to post
        //        AddClientWorkoutDto addClientWorkoutDto = new AddClientWorkoutDto()
        //        {
        //            ClientId = ClientId,
        //            Frequency = frequency,
        //            WorkoutPlanId = workoutplanId,
        //        };

        //        var Client = ExecuteHttpClient;
        //        var clientWorkouts = await Client.ExecuteRoute<ClientWorkoutDto>(HttpMethod.Post, RouteUri.UriClientWorkouts,addClientWorkoutDto);

        //        if(Client.HttpStatusCode != System.Net.HttpStatusCode.OK)
        //        {
        //            //error with Post
        //            //TODO pass in pageHandler to get error to display??                    
        //            // return RedirectToPage("CreateWorkout","Modal");
        //            ErrorMessage = Client.ReturnedError;
        //            return RedirectToPage("CreateWorkout","Modal");
        //        }
        //        else
        //        {
        //            return RedirectToPage("ClientWorkouts");
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        throw;
        //    }
        //    //return RedirectToPage("ClientWorkouts");
        //}
    }
}