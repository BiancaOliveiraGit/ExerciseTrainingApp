using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using TrainingApi.ErrorMiddleware;

namespace TrainingApi.Data
{
    public partial class Repository : IRepository
    {
        private readonly AppDbContext _appDbContext;
        public Repository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Client GetClientByObjectIdentifier(string identifier)
        {
            try
            {
                var client = _appDbContext.Clients.Where(w => w.ObjectIdentifier == identifier)
                                        .Select(s => s).FirstOrDefault();
                if(client == null)
                {
                    client = new Client();
                }
                return client;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Client GetClientById(int id)
        {
            try
            {
                var client =  _appDbContext.Clients.Where(w => w.ClientId == id)
                                        .Select(s => s).FirstOrDefault();
                if (client == null)
                {
                    client = new Client();
                }
                return client;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
               

        public IEnumerable<Client> GetClients()
        {
            try
            {
                var list = _appDbContext.Clients.Select(s => s).ToList();
                return list;
            }
            catch (Exception e)
            {
                throw e;
            }                                   
        }

        public Client PostNewClient(Client newClient)
        {
            try
            {
                //check that client doesn't exist
                var exists = _appDbContext.Clients.Where(w => w.ObjectIdentifier == newClient.ObjectIdentifier)
                                                  .Select(s => s).FirstOrDefault();
                if (exists != null)
                    throw new HttpStatusCodeException(HttpStatusCode.BadRequest, "Client Already Exists");

                //check that unique email 
                var emailUnique = _appDbContext.Clients.Where(w => w.Email == newClient.Email)
                                                        .Select(s => s).ToList();

                if (emailUnique.Count > 0)
                    throw new HttpStatusCodeException(HttpStatusCode.BadRequest, "Must have a unique email. " + newClient.Email + " already in system");

                var item = _appDbContext.Add(newClient);
                item.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                var isOk = _appDbContext.SaveChanges();

                return item.Entity;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Client UpdateClient(int id, Client updateClient)
        {
            try
            {
                //check that client  exists
                var existingClient = _appDbContext.Clients.Where(w => w.ObjectIdentifier == updateClient.ObjectIdentifier)
                                                  .Select(s => s).FirstOrDefault();
                if (existingClient != null)
                    throw new HttpStatusCodeException(HttpStatusCode.BadRequest, string.Format("ClientID {0},- {1} Doesn't Exist in system", updateClient.ClientId,updateClient.LastName));

                //update client
                existingClient.FirstName = updateClient.FirstName;
                existingClient.LastName = updateClient.LastName;
                existingClient.Email = updateClient.Email;
                existingClient.HomeAddress = updateClient.HomeAddress;
                existingClient.Mobile = updateClient.Mobile;

                var isOk = _appDbContext.SaveChanges();

                return existingClient;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
