using System;
using System.Collections.Generic;
using System.Linq;
using CoverAll_API.B_BLL.Interfaces;
using CoverAll_API.C_DAL.Interfaces;
using CoverAll_API.C_DAL.Interfaces;
using CoverAll_API.C_DAL.Model;

namespace CoverAll_API.B_BLL.Service
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository repository;
        private readonly IClienteRepository repositoryCliente;


        public LoginService(ILoginRepository repository, IClienteRepository repositoryCliente)
        {
            this.repository = repository;
            this.repositoryCliente = repositoryCliente;
        }
        public void Add(Login entity)
        {
            this.repository.Add(entity);
        }

        public void Delete(Login entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<Login> GetList()
        {
            throw new NotImplementedException();
        }

        public Cliente LogIn(string usuario, string senha)
        {
            var login = this.repository.LogIn(usuario, senha);
            if (login != null)
            {
                var cliente = this.repositoryCliente.GetList().Where(x => x.Id == login.IdCLiente).FirstOrDefault();

                return cliente;
            }
            return null;
        }

        public bool SaveChanges()
        {
            return this.repository.SaveChanges();
        }

        public void Update(Login entity)
        {
            this.repository.Update(entity);
        }
    }
}
