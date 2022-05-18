using System;
using System.Collections.Generic;
using System.Linq;
using CoverAll_API.C_DAL.Config;
using CoverAll_API.C_DAL.Interfaces;
using CoverAll_API.C_DAL.Model;

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
            dbContext.Pedidos.Add(entity);
        }

        public void Delete(Pedido entity)
        {
            this.dbContext.Pedidos.Remove(entity);
        }

        public ICollection<Pedido> GetList()
        {
            return this.dbContext.Pedidos.ToList();
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
