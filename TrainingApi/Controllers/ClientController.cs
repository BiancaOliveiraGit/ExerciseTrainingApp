using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TrainingApi.Data;


namespace TrainingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IRepository _Repository;

        public ClientController(IRepository repository)
        {
            _Repository = repository;
        }

        // GET api/client
        [HttpGet]
        public ActionResult<IEnumerable<Client>> Get()
        {
            var clients = _Repository.GetClients();
            return Ok(clients);
        }

        // GET api/client/5
        [HttpGet("{id}")]
        public ActionResult<Client> Get(int id)
        {
            var client = _Repository.GetClientById(id);           
            return Ok(client);
        }

        // POST api/client
        [HttpPost]
        public ActionResult<Client> Post([FromBody] Client newClient)
        {
            var postedClient = _Repository.PostNewClient(newClient);
            return Ok(postedClient);
        }

        // PUT api/client/5
        [HttpPut("{id}")]
        public ActionResult<Client> Put(int id, [FromBody] Client updateClient)
        {
            var postedClient = _Repository.UpdateClient(id, updateClient);
            return Ok(postedClient);
        }

       /* // DELETE api/client/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
