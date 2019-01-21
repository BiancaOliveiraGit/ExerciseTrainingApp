
using System.Collections.Generic;
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
            var  workoutPlans = _Repository.GetWorkoutPlans();
            return Ok(workoutPlans);
        }

        // GET api/workoutplan/5
        [HttpGet("{id}")]
        public ActionResult<WorkoutPlan> Get(int id)
        {
             var   workoutPlan = _Repository.GetWorkoutPlanById(id);
             return Ok(workoutPlan);
        }

        // POST api/workoutplan
        [HttpPost]
        public ActionResult<WorkoutPlan> Post([FromBody] WorkoutPlan newWorkoutPlan)
        {
            var  postedWorkoutPlan = _Repository.PostNewWorkoutPlan(newWorkoutPlan);
            return Ok(postedWorkoutPlan);
        }

        // PUT api/workoutplan/5
        [HttpPut("{id}")]
        public ActionResult<WorkoutPlan> Put(int id, [FromBody] WorkoutPlan updateWorkoutPlan)
        {
            var  postedWorkoutPlan = _Repository.UpdateWorkoutPlan(id, updateWorkoutPlan);
            return Ok(postedWorkoutPlan);
        }

        /* // DELETE api/workoutplan/5
         [HttpDelete("{id}")]
         public void Delete(int id)
         {
         }*/
    }
}
