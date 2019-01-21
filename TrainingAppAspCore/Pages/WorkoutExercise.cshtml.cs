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
    public class WorkoutExerciseModel : PageModel
    {
        IExecuteTrainingHttpClient ExecuteHttpClient;
        public List<WorkoutExerciseDto> WorkoutExercise { get; set; }
        public List<ExerciseDto> Exercises { get; set; }
        public int workoutplanId { get; set; }

        public WorkoutExerciseModel(IExecuteTrainingHttpClient executeTrainingClient)
        {
            ExecuteHttpClient = executeTrainingClient;
        }

        public async Task OnGet()
        {
            try
            {
                var Client = ExecuteHttpClient;
                WorkoutExercise = await Client.ExecuteRoute<List<WorkoutExerciseDto>>(HttpMethod.Get, RouteUri.UriWorkoutExercises);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void GetExercise(int workoutId)
        {
            try
            {
                var Client = ExecuteHttpClient;
                Exercises = WorkoutExercise.Where(w => w.WorkoutPlanId == workoutId)
                                            .Select(s => s.Exercise).ToList();
            }
            catch (Exception e)
            {
                throw;
            }
            
        }
    }
}