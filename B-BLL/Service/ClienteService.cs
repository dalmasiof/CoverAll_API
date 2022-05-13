using System;
using System.Collections.Generic;
using CoverAll_API.B_BLL.Interfaces;
using CoverAll_API.C_DAL.Interface;
using CoverAll_API.C_DAL.Interfaces;
using CoverAll_API.C_DAL.Model;

namespace CoverAll_API.B_BLL.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository repository;
        public ClienteService(IClienteRepository repository)
        {
            this.repository = repository;

        }

        public void Add(Cliente entity)
        {
            repository.Add(entity);
        }

        public void Delete(Cliente entity)
        {
            repository.Delete(entity);
        }

        public ICollection<Cliente> GetList()
        {
            return repository.GetList();
        }

        public bool SaveChanges()
        {
            return this.repository.SaveChanges();
        }

        public void Update(Cliente entity)
        {
            repository.Update(entity);
        }
    }
}
