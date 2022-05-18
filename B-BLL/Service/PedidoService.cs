using System;
using System.Collections.Generic;
using CoverAll_API.B_BLL.Interfaces;
using CoverAll_API.C_DAL.Interfaces;
using CoverAll_API.C_DAL.Model;

namespace CoverAll_API.B_BLL.Service
{
    public class PedidoService : IPedidoService
    {

        private readonly IPedidoRepository repository;
        public PedidoService(IPedidoRepository repository)
        {
            this.repository = repository;

        }
        public void Add(Pedido entity)
        {
            repository.Add(entity);
        }

        public void Delete(Pedido entity)
        {
            repository.Delete(entity);
        }

        public ICollection<Pedido> GetList()
        {
            return repository.GetList();
        }

        public bool SaveChanges()
        {
            return this.repository.SaveChanges();
        }

        public void Update(Pedido entity)
        {
            repository.Update(entity);
        }
    }
}
