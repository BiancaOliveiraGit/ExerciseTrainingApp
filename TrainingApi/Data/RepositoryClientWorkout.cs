using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApi.Data
{
    public partial class Repository 
    {
        public ClientWorkout GetClientWorkoutById(int id)
        {
            //TODO include nested objects
            try
            {
                var item = _appDbContext.ClientWorkouts.Where(w => w.ClientWorkoutId == id)
                                        .Include(i => i.ClientExercises)
                                        .Include(i => i.WorkoutPlan)
                                        .Select(s => s).FirstOrDefault();
                
                return item;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }

        public IEnumerable<ClientWorkout> GetClientWorkouts()
        {
            //TODO include nested objects
            try
            {
                var list = _appDbContext.ClientWorkouts
                                        .Include(i => i.ClientExercises)
                                        .Include(i => i.WorkoutPlan)
                                        .Select(s => s).ToList();
                return list;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }

        public ClientWorkout PostNewClientWorkout(ClientWorkout newClientWorkout)
        {
            try
            {
                //TODO test this because of list of client exercises
                //Do I add all ClientExercises at this point or do a separate call to postClientExercises

                //check that workoutplan exists
                var existingWorkout = _appDbContext.WorkoutPlans.Where(w => w.WorkoutPlanId == newClientWorkout.WorkoutPlanId)
                                                     .Select(s => s).FirstOrDefault();

                if (existingWorkout == null)
                    throw new Exception(string.Format("Workout Plan id: {0} does not exist in the system", newClientWorkout.WorkoutPlanId));

                //get client 
                //check that ClientWorkout doesn't exist
                var exists = _appDbContext.ClientWorkouts.Where(w => w.WorkoutPlanId == newClientWorkout.WorkoutPlanId
                                                                    && w.ClientId == newClientWorkout.ClientId)
                                                          .Select(s => s).FirstOrDefault();
                if (exists != null)
                    throw new Exception(string.Format("ClientWorkout id {0} for {1} Workout Plan already exists", exists.ClientWorkoutId, existingWorkout.Name));

                var item = _appDbContext.Add(newClientWorkout);
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

        public ClientWorkout UpdateClientWorkout(int id, ClientWorkout updateClientWorkout)
        {
            try
            {
                //get exercise object
                var existingWorkout = _appDbContext.WorkoutPlans.Where(w => w.WorkoutPlanId == updateClientWorkout.WorkoutPlanId)
                                                              .Select(s => s).FirstOrDefault();

                if (existingWorkout == null)
                    throw new Exception("This Workout Plan Doesn't Exist in system");


                //check that ClientWorkout exists
                var existingClientWorkout = _appDbContext.ClientWorkouts.Where(w => w.ClientWorkoutId == updateClientWorkout.ClientWorkoutId)
                                                  .Select(s => s).FirstOrDefault();
                if (existingClientWorkout != null)
                    throw new Exception(string.Format("ClientWorkoutID {0},- {1} Doesn't Exist in system", updateClientWorkout.ClientWorkoutId, existingWorkout.Name));

                //update ClientWorkout
                existingClientWorkout.Frequency = updateClientWorkout.Frequency;
                var isOk = _appDbContext.SaveChanges();

                return existingClientWorkout;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }

    
        }
    }
}
