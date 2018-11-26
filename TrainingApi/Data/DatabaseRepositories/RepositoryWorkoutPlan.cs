using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApi.Data
{
    public partial class Repository 
    {
        public WorkoutPlan GetWorkoutPlanById(int id)
        {
            try
            {
                var item = _appDbContext.WorkoutPlans.Where(w => w.WorkoutPlanId == id)
                                        .Select(s => s).FirstOrDefault();
                return item;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }

        public IEnumerable<WorkoutPlan> GetWorkoutPlans()
        {
            try
            {
                var list = _appDbContext.WorkoutPlans.Select(s => s).ToList();
                return list;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }

        public WorkoutPlan PostNewWorkoutPlan(WorkoutPlan newWorkoutPlan)
        {
            try
            {
                //check that WorkoutPlan doesn't exist
                var exists = _appDbContext.WorkoutPlans.Where(w => w.Name == newWorkoutPlan.Name)
                                                          .Select(s => s).FirstOrDefault();
                if (exists != null)
                    throw new Exception(string.Format("WorkoutPlan {0}  already exists", newWorkoutPlan.Name));

                var item = _appDbContext.Add(newWorkoutPlan);
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

        public WorkoutPlan UpdateWorkoutPlan(int id, WorkoutPlan updateWorkoutPlan)
        {
            try
            {
                //check that WorkoutPlan exists
                var existingWorkoutPlan = _appDbContext.WorkoutPlans.Where(w => w.WorkoutPlanId == updateWorkoutPlan.WorkoutPlanId)
                                                  .Select(s => s).FirstOrDefault();
                if (existingWorkoutPlan != null)
                    throw new Exception(string.Format("WorkoutPlanID {0}, Doesn't Exist in system", updateWorkoutPlan.WorkoutPlanId));

                //update WorkoutPlan
                existingWorkoutPlan.DoNotUse = updateWorkoutPlan.DoNotUse;
                existingWorkoutPlan.Name = updateWorkoutPlan.Name;

                var isOk = _appDbContext.SaveChanges();

                return existingWorkoutPlan;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }
    }
}
