using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApi.Data
{
    public interface IRepository
    {
        #region Client
        Client GetClientById(int id);
        Client GetClientByEmail(string email);
        IEnumerable<Client> GetClients();
        Client PostNewClient(Client newClient);
        Client UpdateClient(int id, Client updateClient);
        #endregion

        #region VideoLibrary
        VideoLibrary GetVideoById(int id);
        IEnumerable<VideoLibrary> GetVideoLibraries();
        VideoLibrary PostNewVideo(VideoLibrary newVideo);
        VideoLibrary UpdateVideo(int id, VideoLibrary updateVideo);
        #endregion

        #region Exercise
        Exercise GetExerciseById(int id);
        IEnumerable<Exercise> GetExercises();
        Exercise PostNewExercise(Exercise newExercise);
        Exercise UpdateExercise(int id, Exercise updateExercise);
        #endregion

        #region ClientExercise
        ClientExercise GetClientExerciseById(int id);
        IEnumerable<ClientExercise> GetClientExercises();
        ClientExercise PostNewClientExercise(ClientExercise newClientExercise);
        ClientExercise UpdateClientExercise(int id, ClientExercise updateClientExercise);
        #endregion

        #region WorkoutPlans
        WorkoutPlan GetWorkoutPlanById(int id);
        IEnumerable<WorkoutPlan> GetWorkoutPlans();
        WorkoutPlan PostNewWorkoutPlan(WorkoutPlan newWorkoutPlan);
        WorkoutPlan UpdateWorkoutPlan(int id, WorkoutPlan updateWorkoutPlan);
        #endregion

        #region ClientWorkouts
        ClientWorkout GetClientWorkoutById(int id);
        IEnumerable<ClientWorkout> GetClientWorkouts();
        IEnumerable<ClientWorkout> GetClientWorkoutByClientId(int id);
        ClientWorkout PostNewClientWorkout(AddClientWorkoutDto newClientWorkout);
        ClientWorkout UpdateClientWorkout(int id, ClientWorkout updateClientWorkout);
        #endregion

        #region WorkoutExercise
        WorkoutExercise GetWorkoutExerciseById(int id);
        IEnumerable<WorkoutExercise> GetWorkoutExercises();
        WorkoutExercise PostNewWorkoutExercise(WorkoutExercise newWorkoutExercise);
        WorkoutExercise UpdateWorkoutExercise(int id, WorkoutExercise updateWorkoutExercise);
        #endregion

        #region Category
        Category GetCategoryById(int id);
        IEnumerable<Category> GetCategories();
        Category PostNewCategory(Category newCategory);
        Category UpdateCategory(int id, Category updateCategory);
        #endregion
    }
}
