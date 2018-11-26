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
            IEnumerable<Client> clients = new List<Client>();
            try
            {
                clients = _Repository.GetClients();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
             
            return Ok(clients);
        }

        // GET api/client/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            Client client = new Client();
            try
            {
                client = _Repository.GetClientById(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(client);
        }

        // POST api/client
        [HttpPost]
        public ActionResult Post([FromBody] Client newClient)
        {
            Client postedClient = new Client();
            try
            {
                postedClient = _Repository.PostNewClient(newClient);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(postedClient);
        }

        // PUT api/client/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Client updateClient)
        {
            Client postedClient = new Client();
            try
            {
                postedClient = _Repository.UpdateClient(id, updateClient);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok(postedClient);
        }

       /* // DELETE api/client/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
