using System;
using System.Collections.Generic;
using System.Linq;
using CoverAll_API.C_DAL.Config;
using CoverAll_API.C_DAL.Interfaces;
using CoverAll_API.C_DAL.Model;

namespace CoverAll_API.C_DAL.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext dbContext;
        public ClienteRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(Cliente entity)
        {
            this.dbContext.Clientes.Add(entity);
        }

        public void Delete(Cliente entity)
        {
            this.dbContext.Clientes.Remove(entity);
        }

        public ICollection<Cliente> GetList()
        {
            return this.dbContext.Clientes.ToList();
        }

        public bool SaveChanges()
        {
            return (this.dbContext.SaveChanges() > 0);
        }

        public void Update(Cliente entity)
        {
            this.dbContext.Clientes.Update(entity);
        }
    }
}
