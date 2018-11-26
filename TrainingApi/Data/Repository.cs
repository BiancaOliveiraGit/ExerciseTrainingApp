using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingApi.Data
{
    public partial class Repository : IRepository
    {
        private readonly AppDbContext _appDbContext;
        public Repository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Client GetClientById(int id)
        {
            try
            {
                var item =  _appDbContext.Clients.Where(w => w.ClientId == id)
                                        .Select(s => s).FirstOrDefault();
                return item;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
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
                //TODO add logging
                throw;
            }                                   
        }

        public Client PostNewClient(Client newClient)
        {
            try
            {
                //check that client doesn't exist
                var exists = _appDbContext.Clients.Where(w => w.FirstName == newClient.FirstName && w.LastName == newClient.LastName)
                                                  .Select(s => s).FirstOrDefault();
                if (exists != null)
                    throw new Exception("Client Already Exists");

                //check that unique email 
                var emailUnique = _appDbContext.Clients.Where(w => w.Email == newClient.Email)
                                                        .Select(s => s).ToList();

                if (emailUnique != null)
                    throw new Exception("Must have a unique email. " + newClient.Email + " already in system");

                var item = _appDbContext.Add(newClient);
                item.State = Microsoft.EntityFrameworkCore.EntityState.Added;
                var isOk = _appDbContext.SaveChanges();

                return item.Entity;
            }
            catch (Exception e)
            {
                //TODO add logging
                throw;
            }
        }

        public Client UpdateClient(int id, Client updateClient)
        {
            try
            {
                //check that client  exists
                var existingClient = _appDbContext.Clients.Where(w => w.ClientId == updateClient.ClientId)
                                                  .Select(s => s).FirstOrDefault();
                if (existingClient != null)
                    throw new Exception(string.Format("ClientID {0},- {1} Doesn't Exist in system", updateClient.ClientId,updateClient.LastName));

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
                //TODO add logging
                throw;
            }
        }
    }
}
