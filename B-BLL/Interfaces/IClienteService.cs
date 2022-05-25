using System;
using System.Collections.Generic;
using CoverAll_API.B_Service;
using CoverAll_API.C_DAL.Model;

namespace CoverAll_API.B_BLL.Interfaces
{
    public interface IClienteService:IBaseService<Cliente>
    {
                ICollection<Pedido> GetPedidosPorCliente(int IdCLiente);

    }
}
