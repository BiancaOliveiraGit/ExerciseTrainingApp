using System.Collections.Generic;
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
            var clientWorkouts = _Repository.GetClientWorkouts();          
            return Ok(clientWorkouts);
        }

        // GET api/clientworkout/5
        [HttpGet("{id}")]
        public ActionResult<ClientWorkout> Get(int id)
        {
            var  clientWorkout = _Repository.GetClientWorkoutById(id);
            return Ok(clientWorkout);
        }

        // GET api/clientworkout/5
        [HttpGet("client/{id}")]
        public ActionResult<List<ClientWorkout>> GetByClient(int id)
        {
            var clientWorkouts = _Repository.GetClientWorkoutByClientId(id);
            return Ok(clientWorkouts);
        }

        // POST api/clientworkout
        [HttpPost]
        public ActionResult<ClientWorkout> Post([FromBody] AddClientWorkoutDto newClientWorkout)
        {
            var postedClientWorkout = _Repository.PostNewClientWorkout(newClientWorkout);
            return Ok(postedClientWorkout);
        }

        // PUT api/clientworkout/5
        [HttpPut("{id}")]
        public ActionResult<ClientWorkout> Put(int id, [FromBody] ClientWorkout updateClientWorkout)
        {
            var  postedClientWorkout = _Repository.UpdateClientWorkout(id, updateClientWorkout);
            return Ok(postedClientWorkout);
        }

        /* // DELETE api/clientworkout/5
         [HttpDelete("{id}")]
         public void Delete(int id)
         {
         }*/
    }
}
