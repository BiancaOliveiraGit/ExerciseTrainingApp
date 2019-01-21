using System;
using System.Collections.Generic;
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
            var clientExercises = _Repository.GetClientExercises(); 
            return Ok(clientExercises);
        }

        // GET api/clientexercise/5
        [HttpGet("{id}")]
        public ActionResult<ClientExercise> Get(int id)
        {
            var clientExercise = _Repository.GetClientExerciseById(id);            
            return Ok(clientExercise);
        }

        // POST api/clientexercise
        [HttpPost]
        public ActionResult<ClientExercise> Post([FromBody] ClientExercise newClientExercise)
        {
            var postedClientExercise = _Repository.PostNewClientExercise(newClientExercise);
            return Ok(postedClientExercise);
        }

        // PUT api/clientexercise/5
        [HttpPut("{id}")]
        public ActionResult<ClientExercise> Put(int id, [FromBody] ClientExercise updateClientExercise)
        {
            var postedClientExercise = _Repository.UpdateClientExercise(id, updateClientExercise);
            return Ok(postedClientExercise);
        }

        /* // DELETE api/clientexercise/5
         [HttpDelete("{id}")]
         public void Delete(int id)
         {
         }*/
    }
}
