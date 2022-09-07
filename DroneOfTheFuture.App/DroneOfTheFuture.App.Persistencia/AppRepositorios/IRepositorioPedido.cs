using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DroneOfTheFuture.App.Dominio;

namespace DroneOfTheFuture.App.Persistencia
{
    public interface IRepositorioPedido
    {
        IEnumerable<Pedidos> GetAllPedido();
        Pedidos AddPedido (Pedidos pedidos);
        Pedidos UpdatePedidos (Pedidos pedidos);
        void DeletePedido(int idPedido);
        Pedidos GetPedidos(int idPedido);
        // Pedidos ReadPedidos(int idPedido);
    }
}