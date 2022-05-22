using System;
using System.Collections.Generic;
using System.Linq;
using CoverAll_API.C_DAL.Config;
using CoverAll_API.C_DAL.Interfaces;
using CoverAll_API.C_DAL.Model;

namespace CoverAll_API.C_DAL.Repository
{
    public class LoginRepository : ILoginRepository
    {
        private readonly DataContext dbContext;
        public LoginRepository(DataContext dbContext)
        {
        this.dbContext = dbContext;            
        }
        public void Add(Login entity)
        {
            this.dbContext.Logins.Add(entity);
        }

        public void Delete(Login entity)
        {
            this.dbContext.Logins.Remove(entity);
        }

        public ICollection<Login> GetList()
        {
            return this.dbContext.Logins.ToList();
        }

        public Login LogIn(string usuario, string senha)
        {
            var login = this.dbContext.Logins.Where(x => x.Usuario == usuario && x.Senha == senha).FirstOrDefault();

            if (login != null) return login;

            return null;
        }

        public bool SaveChanges()
        {
            return (this.dbContext.SaveChanges() > 0);
        }

        public void Update(Login entity)
        {
            this.dbContext.Logins.Update(entity);
        }
    }
}
