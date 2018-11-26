﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApi.Data
{
    public partial class Repository 
    {
        public ClientExercise GetClientExerciseById(int id)
        {
            try
            {
                var item = _appDbContext.ClientExercises.Where(w => w.ClientExerciseId == id)
                                        .Select(s => s).FirstOrDefault();
                return item;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }

        public IEnumerable<ClientExercise> GetClientExercises()
        {
            try
            {
                var list = _appDbContext.ClientExercises.Select(s => s).ToList();
                return list;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }

        public ClientExercise PostNewClientExercise(ClientExercise newClientExercise)
        {
            try
            {
                //check that ClientExercise doesn't exist
                var exists = _appDbContext.ClientExercises.Where(w => w.ExerciseId == newClientExercise.ExerciseId 
                                                                    && w.ClientWorkoutId == newClientExercise.ClientWorkoutId)
                                                          .Select(s => s).FirstOrDefault();
                if (exists != null)
                    throw new Exception(string.Format("ClientExercise {0} for this Workout Plan already exists", newClientExercise.Exercise.Name));

                var item = _appDbContext.Add(newClientExercise);
                item.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                var isOk = _appDbContext.SaveChanges();

                return item.Entity;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }

        public ClientExercise UpdateClientExercise(int id, ClientExercise updateClientExercise)
        {
            try
            {
                //get exercise object
                var existingExercise = _appDbContext.Exercises.Where(w => w.ExerciseId == updateClientExercise.ExerciseId)
                                                              .Select(s => s).FirstOrDefault();

                if (existingExercise == null)
                    throw new Exception("This Exercise Doesn't Exist in system");


                //check that ClientExercise exists
                var existingClientExercise = _appDbContext.ClientExercises.Where(w => w.ClientExerciseId == updateClientExercise.ClientExerciseId)
                                                  .Select(s => s).FirstOrDefault();
                if (existingClientExercise != null)
                    throw new Exception(string.Format("ClientExerciseID {0},- {1} Doesn't Exist in system", updateClientExercise.ClientExerciseId, existingExercise.Name));

                //update ClientExercise
                existingClientExercise.Exercise = existingExercise;
                existingClientExercise.ExerciseId = existingExercise.ExerciseId;
                existingClientExercise.IsActive = updateClientExercise.IsActive;
                // existingClientExercise.ClientWorkoutId = updateClientExercise.ClientWorkoutId;    //not allowing to update

                var isOk = _appDbContext.SaveChanges();

                return existingClientExercise;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }
    }
}
