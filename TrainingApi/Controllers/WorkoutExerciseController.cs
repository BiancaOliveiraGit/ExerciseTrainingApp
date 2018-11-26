using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TrainingApi.Data;


namespace TrainingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkoutExerciseController : ControllerBase
    {
        private readonly IRepository _Repository;

        public WorkoutExerciseController(IRepository repository)
        {
            _Repository = repository;
        }

        // GET api/workoutexercise
        [HttpGet]
        public ActionResult<IEnumerable<WorkoutExercise>> Get()
        {
            IEnumerable<WorkoutExercise> WorkoutExercises = new List<WorkoutExercise>();
            try
            {
                WorkoutExercises = _Repository.GetWorkoutExercises();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
             
            return Ok(WorkoutExercises);
        }

        // GET api/workoutexercise/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            WorkoutExercise WorkoutExercise = new WorkoutExercise();
            try
            {
                WorkoutExercise = _Repository.GetWorkoutExerciseById(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(WorkoutExercise);
        }

        // POST api/workoutexercise
        [HttpPost]
        public ActionResult Post([FromBody] WorkoutExercise newWorkoutExercise)
        {
            WorkoutExercise postedWorkoutExercise = new WorkoutExercise();
            try
            {
                postedWorkoutExercise = _Repository.PostNewWorkoutExercise(newWorkoutExercise);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(postedWorkoutExercise);
        }

        // PUT api/workoutexercise/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] WorkoutExercise updateWorkoutExercise)
        {
            WorkoutExercise postedWorkoutExercise = new WorkoutExercise();
            try
            {
                postedWorkoutExercise = _Repository.UpdateWorkoutExercise(id, updateWorkoutExercise);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(postedWorkoutExercise);
        }

        /* // DELETE api/workoutexercise/5
         [HttpDelete("{id}")]
         public void Delete(int id)
         {
         }*/
    }
}
