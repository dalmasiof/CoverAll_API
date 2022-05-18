using System;
using System.Collections.Generic;
using System.Linq;
using CoverAll_API.C_DAL.Config;
using CoverAll_API.C_DAL.Interfaces;
using CoverAll_API.C_DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace CoverAll_API.C_DAL.Repository
{
    public class PedidoRepository : IPedidoRepository
    {
        private DataContext dbContext;
        public PedidoRepository(DataContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void Add(Pedido entity)
        {
            entity.Produtos.All(x=>{
                dbContext.Produtos.Attach(x);
                return true;
            });

          
            dbContext.Pedidos.Add(entity);
        }

        public void Delete(Pedido entity)
        {
            this.dbContext.Pedidos.Remove(entity);
        }

        public ICollection<Pedido> GetList()
        {
            return this.dbContext.Pedidos.Include("Produtos").ToList();
        }

        public bool SaveChanges()
        {
            return (this.dbContext.SaveChanges() > 0);
        }

        public void Update(Pedido entity)
        {
            this.dbContext.Pedidos.Update(entity);
        }
    }
}
