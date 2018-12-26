﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApi.Data
{
    public partial class Repository 
    {
        public Exercise GetExerciseById(int id)
        {
            try
            {
                var item = _appDbContext.Exercises.Where(w => w.ExerciseId == id)
                                        .Select(s => s)
                                        .Include(i => i.VideoLibrary).FirstOrDefault();
                return item;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }

        public IEnumerable<Exercise> GetExercises()
        {
            try
            {
                var list = _appDbContext.Exercises.Select(s => s)
                                                    .Include(i => i.VideoLibrary).ToList();
                return list;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }

        public Exercise PostNewExercise(Exercise newExercise)
        {
            try
            {
                //check that Exercise doesn't exist
                var exists = _appDbContext.Exercises.Where(w => w.Name == newExercise.Name && w.CategoryId == newExercise.CategoryId && w.DoNotUse == false)
                                                  .Select(s => s).FirstOrDefault();
                if (exists != null)
                    throw new Exception(string.Format("Exercise {0} for this category already exists", newExercise.Name));

                var item = _appDbContext.Add(newExercise);
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

        public Exercise UpdateExercise(int id, Exercise updateExercise)
        {
            try
            {
                //check that Exercise exists
                var existingExercise = _appDbContext.Exercises.Where(w => w.ExerciseId == updateExercise.ExerciseId)
                                                  .Select(s => s).FirstOrDefault();
                if (existingExercise != null)
                    throw new Exception(string.Format("ExerciseID {0},- {1} Doesn't Exist in system", updateExercise.ExerciseId, updateExercise.Name));

                //update Exercise
                existingExercise.Name = updateExercise.Name;
                existingExercise.VideoLibraryId = updateExercise.VideoLibraryId;
                existingExercise.CategoryId = updateExercise.CategoryId;
                existingExercise.DoNotUse = updateExercise.DoNotUse;

                var isOk = _appDbContext.SaveChanges();

                return existingExercise;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }
    }
}
