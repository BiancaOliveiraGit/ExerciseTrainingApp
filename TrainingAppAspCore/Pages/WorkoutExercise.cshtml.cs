using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TrainingAppAspCore.Dto;
using Microsoft.Extensions.Logging;

namespace TrainingAppAspCore.Pages
{
    public class WorkoutExerciseModel : PageModel
    {
        IExecuteTrainingHttpClient ExecuteHttpClient;
        public List<WorkoutExerciseDto> WorkoutExercise { get; set; }
        public List<ExerciseDto> Exercises { get; set; }
        public int workoutplanId { get; set; }
        private ILogger _logger;

        public WorkoutExerciseModel(IExecuteTrainingHttpClient executeTrainingClient, ILogger<WorkoutExerciseModel> logger)
        {
            ExecuteHttpClient = executeTrainingClient;
            _logger = logger;
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
                _logger.LogError(e, "Error in Get WorkoutExercise");
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
                _logger.LogError(e, "Error in Get Exercise");
            }
            
        }
    }
}