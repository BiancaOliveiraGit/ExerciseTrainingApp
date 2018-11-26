using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TrainingApi.Data;


namespace TrainingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutPlanController : ControllerBase
    {
        private readonly IRepository _Repository;

        public WorkoutPlanController(IRepository repository)
        {
            _Repository = repository;
        }

        // GET api/workoutplan
        [HttpGet]
        public ActionResult<IEnumerable<WorkoutPlan>> Get()
        {
            IEnumerable<WorkoutPlan> workoutPlans = new List<WorkoutPlan>();
            try
            {
                workoutPlans = _Repository.GetWorkoutPlans();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
             
            return Ok(workoutPlans);
        }

        // GET api/workoutplan/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            WorkoutPlan workoutPlan = new WorkoutPlan();
            try
            {
                workoutPlan = _Repository.GetWorkoutPlanById(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(workoutPlan);
        }

        // POST api/workoutplan
        [HttpPost]
        public ActionResult Post([FromBody] WorkoutPlan newWorkoutPlan)
        {
            WorkoutPlan postedWorkoutPlan = new WorkoutPlan();
            try
            {
                postedWorkoutPlan = _Repository.PostNewWorkoutPlan(newWorkoutPlan);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(postedWorkoutPlan);
        }

        // PUT api/workoutplan/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] WorkoutPlan updateWorkoutPlan)
        {
            WorkoutPlan postedWorkoutPlan = new WorkoutPlan();
            try
            {
                postedWorkoutPlan = _Repository.UpdateWorkoutPlan(id, updateWorkoutPlan);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(postedWorkoutPlan);
        }

        /* // DELETE api/workoutplan/5
         [HttpDelete("{id}")]
         public void Delete(int id)
         {
         }*/
    }
}
