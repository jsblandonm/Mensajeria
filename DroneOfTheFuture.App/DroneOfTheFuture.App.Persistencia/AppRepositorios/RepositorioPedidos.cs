using System;
using Microsoft.EntityFrameworkCore;
using DroneOfTheFuture.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace DroneOfTheFuture.App.Persistencia
{
    public class RepositorioPedidos : IRepositorioPedido
    {
        private readonly AppContexto _appContext;
        public RepositorioPedidos(AppContexto appContext)
        {
            _appContext = appContext;
        }
                public RepositorioPedidos (){
            _appContext = new AppContexto();
        }
        public Pedidos AddPedido(Pedidos pedidos)
        {
            var pedidosAgregado = _appContext.Pedido.Add(pedidos);
            _appContext.SaveChanges();
            return pedidosAgregado.Entity;
        }

        public void DeletePedido(int idPedido)
        {
            var pedidoEncontrado = _appContext.Pedido.FirstOrDefault(p => p.Id == idPedido);
            if (pedidoEncontrado == null)
            {
                return;
            }
            _appContext.Pedido.Remove(pedidoEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Pedidos> GetAllPedido()
        {
            return _appContext.Pedido;
        }

        public Pedidos GetPedidos(int idPedido)
        {
            return _appContext.Pedido.Where(p => p.Id == idPedido).Include(p => p.SuEncargado).Include(p => p.Mensajeria).FirstOrDefault();

        }

        public Pedidos UpdatePedidos(Pedidos pedidos)
        {
            var pedidoEncontrado = _appContext.Pedido.FirstOrDefault(p => p.Id == pedidos.Id);
            if(pedidoEncontrado != null)
            {

                pedidoEncontrado.NombreDelPaquete = pedidos.NombreDelPaquete;
                pedidoEncontrado.Peso = pedidos.Peso;
                pedidoEncontrado.FechaCreacion = pedidos.FechaCreacion;
                pedidoEncontrado.EstadoDelPedido = pedidos.EstadoDelPedido;
                pedidoEncontrado.SuComprador = pedidos.SuComprador;
                pedidoEncontrado.SuEncargado = pedidos.SuEncargado;
                pedidoEncontrado.Mensajeria = pedidos.Mensajeria;
                pedidoEncontrado.SuComprador.Compras = pedidos.SuComprador.Compras;
                _appContext.SaveChanges();
            }
            return pedidoEncontrado;
        }
    }
}