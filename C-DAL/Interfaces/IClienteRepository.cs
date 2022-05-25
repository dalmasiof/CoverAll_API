using System;
using System.Collections.Generic;
using CoverAll_API.C_DAL.Model;

namespace CoverAll_API.C_DAL.Interfaces
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        ICollection<Pedido> GetPedidosPorCliente(int IdCLiente);
    }
}
