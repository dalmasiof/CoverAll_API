using System;
using System.Collections.Generic;
using System.Linq;
using CoverAll_API.B_BLL.Interfaces;
using CoverAll_API.C_DAL.Interfaces;
using CoverAll_API.C_DAL.Interfaces;
using CoverAll_API.C_DAL.Model;

namespace CoverAll_API.B_BLL.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository repository;
        private readonly ILoginRepository repositoryLogin;

        public ClienteService(IClienteRepository repository,ILoginRepository repositoryLogin)
        {
            this.repository = repository;
            this.repositoryLogin = repositoryLogin;

        }

        public void Add(Cliente entity)
        {
            repository.Add(entity);
            repository.SaveChanges();
            var objLogin = new Login(){
                Id=0,
                IdCLiente=entity.Id,
                Senha="admin",
                Usuario=entity.email
            };
            repositoryLogin.Add(objLogin);

        }

        public void Delete(Cliente entity)
        {

            var loginToDelete = this.repositoryLogin.GetList().Where(x=>x.IdCLiente == entity.Id).FirstOrDefault();

            repository.Delete(entity);
            repository.SaveChanges();
            repositoryLogin.Delete(loginToDelete);
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
