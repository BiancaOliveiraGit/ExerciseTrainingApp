using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TrainingApi.Data;


namespace TrainingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientExerciseController : ControllerBase
    {
        private readonly IRepository _Repository;

        public ClientExerciseController(IRepository repository)
        {
            _Repository = repository;
        }

        // GET api/clientexercise
        [HttpGet]
        public ActionResult<IEnumerable<ClientExercise>> Get()
        {
            IEnumerable<ClientExercise> clientExercises = new List<ClientExercise>();
            try
            {
                clientExercises = _Repository.GetClientExercises();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
             
            return Ok(clientExercises);
        }

        // GET api/clientexercise/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            ClientExercise clientExercise = new ClientExercise();
            try
            {
                clientExercise = _Repository.GetClientExerciseById(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(clientExercise);
        }

        // POST api/clientexercise
        [HttpPost]
        public ActionResult Post([FromBody] ClientExercise newClientExercise)
        {
            ClientExercise postedClientExercise = new ClientExercise();
            try
            {
                postedClientExercise = _Repository.PostNewClientExercise(newClientExercise);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(postedClientExercise);
        }

        // PUT api/clientexercise/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ClientExercise updateClientExercise)
        {
            ClientExercise postedClientExercise = new ClientExercise();
            try
            {
                postedClientExercise = _Repository.UpdateClientExercise(id, updateClientExercise);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(postedClientExercise);
        }

        /* // DELETE api/clientexercise/5
         [HttpDelete("{id}")]
         public void Delete(int id)
         {
         }*/
    }
}
