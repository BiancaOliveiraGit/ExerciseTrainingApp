using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using TrainingApi.ErrorMiddleware;

namespace TrainingApi.Data
{
    public partial class Repository 
    {
        public WorkoutExercise GetWorkoutExerciseById(int id)
        {
            try
            {
                var item = _appDbContext.WorkoutExercises.Where(w => w.WorkoutExerciseId == id)
                                                        .Include(i => i.Exercise)
                                                        .Select(s => s)
                                                        .Include(i => i.Exercise.VideoLibrary).FirstOrDefault();
                return item;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<WorkoutExercise> GetWorkoutExercises()
        {
            try
            {
                var list = _appDbContext.WorkoutExercises.Select(s => s)
                                                        .Include(i => i.Exercise)
                                                        .Include(i => i.Exercise.VideoLibrary).ToList();
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public WorkoutExercise PostNewWorkoutExercise(WorkoutExercise newWorkoutExercise)
        {
            try
            {
                //check that WorkoutExercise doesn't exist
                var exists = _appDbContext.WorkoutExercises.Where(w => w.ExerciseId == newWorkoutExercise.ExerciseId 
                                                                    && w.WorkoutPlanId == newWorkoutExercise.WorkoutPlanId)
                                                          .Select(s => s).FirstOrDefault();
                if (exists != null)
                    throw new HttpStatusCodeException(HttpStatusCode.BadRequest, string.Format("WorkoutExercise ID:{0} for Workout Plan ID:{1} already exists", newWorkoutExercise.ExerciseId, newWorkoutExercise.WorkoutPlanId));

                var item = _appDbContext.Add(newWorkoutExercise);
                item.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                var isOk = _appDbContext.SaveChanges();

                return item.Entity;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public WorkoutExercise UpdateWorkoutExercise(int id, WorkoutExercise updateWorkoutExercise)
        {
            try
            {
                //get exercise object
                var existingExercise = _appDbContext.Exercises.Where(w => w.ExerciseId == updateWorkoutExercise.ExerciseId)
                                                              .Select(s => s).FirstOrDefault();

                if (existingExercise == null)
                    throw new HttpStatusCodeException(HttpStatusCode.BadRequest, "This Exercise Doesn't Exist in system");


                //check that WorkoutExercise exists
                var existingWorkoutExercise = _appDbContext.WorkoutExercises.Where(w => w.WorkoutExerciseId == updateWorkoutExercise.WorkoutExerciseId)
                                                  .Select(s => s).FirstOrDefault();
                if (existingWorkoutExercise != null)
                    throw new HttpStatusCodeException(HttpStatusCode.BadRequest, string.Format("WorkoutExerciseID {0},- {1} Doesn't Exist in system", updateWorkoutExercise.WorkoutExerciseId, existingExercise.Name));

                //update WorkoutExercise
                existingWorkoutExercise.ExerciseId = existingExercise.ExerciseId;
                existingWorkoutExercise.DoNotUse = updateWorkoutExercise.DoNotUse;

                var isOk = _appDbContext.SaveChanges();

                return existingWorkoutExercise;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
