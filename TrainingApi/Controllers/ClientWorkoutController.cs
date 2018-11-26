using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TrainingApi.Data;


namespace TrainingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientWorkoutController : ControllerBase
    {
        private readonly IRepository _Repository;

        public ClientWorkoutController(IRepository repository)
        {
            _Repository = repository;
        }

        // GET api/clientworkout
        [HttpGet]
        public ActionResult<IEnumerable<ClientWorkout>> Get()
        {
            IEnumerable<ClientWorkout> clientWorkouts = new List<ClientWorkout>();
            try
            {
                clientWorkouts = _Repository.GetClientWorkouts();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
             
            return Ok(clientWorkouts);
        }

        // GET api/clientworkout/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            ClientWorkout clientWorkout = new ClientWorkout();
            try
            {
                clientWorkout = _Repository.GetClientWorkoutById(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(clientWorkout);
        }

        // POST api/clientworkout
        [HttpPost]
        public ActionResult Post([FromBody] ClientWorkout newClientWorkout)
        {
            ClientWorkout postedClientWorkout = new ClientWorkout();
            try
            {
                postedClientWorkout = _Repository.PostNewClientWorkout(newClientWorkout);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(postedClientWorkout);
        }

        // PUT api/clientworkout/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ClientWorkout updateClientWorkout)
        {
            ClientWorkout postedClientWorkout = new ClientWorkout();
            try
            {
                postedClientWorkout = _Repository.UpdateClientWorkout(id, updateClientWorkout);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(postedClientWorkout);
        }

        /* // DELETE api/clientworkout/5
         [HttpDelete("{id}")]
         public void Delete(int id)
         {
         }*/
    }
}
