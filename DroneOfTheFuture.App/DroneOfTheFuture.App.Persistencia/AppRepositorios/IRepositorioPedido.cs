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
<<<<<<< HEAD
        // Pedidos ReadPedidos(int idPedido);
=======
>>>>>>> 82f0319ae87c0f74a52d72163b39d34fa0894bc7
    }
}