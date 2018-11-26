using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TrainingApi.Data;


namespace TrainingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciseController : ControllerBase
    {
        private readonly IRepository _Repository;

        public ExerciseController(IRepository repository)
        {
            _Repository = repository;
        }

        // GET api/exercise
        [HttpGet]
        public ActionResult<IEnumerable<Exercise>> Get()
        {
            IEnumerable<Exercise> exercises = new List<Exercise>();
            try
            {
                exercises = _Repository.GetExercises();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
             
            return Ok(exercises);
        }

        // GET api/exercise/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            Exercise exercise = new Exercise();
            try
            {
                exercise = _Repository.GetExerciseById(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(exercise);
        }

        // POST api/exercise
        [HttpPost]
        public ActionResult Post([FromBody] Exercise newExercise)
        {
            Exercise postedExercise = new Exercise();
            try
            {
                postedExercise = _Repository.PostNewExercise(newExercise);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(postedExercise);
        }

        // PUT api/exercise/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Exercise updateExercise)
        {
            Exercise postedExercise = new Exercise();
            try
            {
                postedExercise = _Repository.UpdateExercise(id, updateExercise);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(postedExercise);
        }

        /* // DELETE api/exercise/5
         [HttpDelete("{id}")]
         public void Delete(int id)
         {
         }*/
    }
}
