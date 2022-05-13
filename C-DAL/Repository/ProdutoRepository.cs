using System;
using System.Collections.Generic;
using System.Linq;
using CoverAll_API.C_DAL.Config;
using CoverAll_API.C_DAL.Interfaces;
using CoverAll_API.C_DAL.Model;

namespace CoverAll_API.C_DAL.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DataContext dbContext;
        public ProdutoRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(Produto entity)
        {
            this.dbContext.Produtos.Add(entity);
        }

        public void Delete(Produto entity)
        {
            this.dbContext.Produtos.Remove(entity);
        }

        public ICollection<Produto> GetList()
        {
            return this.dbContext.Produtos.ToList();
        }

        public bool SaveChanges()
        {
            return (this.dbContext.SaveChanges() > 0);

        }

        public void Update(Produto entity)
        {
            this.dbContext.Produtos.Update(entity);
        }
    }
}
