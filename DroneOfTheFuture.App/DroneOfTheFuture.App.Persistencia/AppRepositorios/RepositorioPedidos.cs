using System;
using Microsoft.EntityFrameworkCore;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persitencia;
using System.Collections.Generic;
using System.Linq;

namespace DroneOfTheFuture.App.Persistencia
{
    public class RepositorioPedidos : IRepositorioPedido
    {
        private readonly APPCT _appContext;
        public RepositorioPedidos(APPCT appContext)
        {
            _appContext = appContext;
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
            return _appContext.Pedido.FirstOrDefault(p => p.Id == idPedido);
        }

        public Pedidos UpdatePedidos(Pedidos pedidos)
        {
            var pedidoEncontrado = _appContext.Pedido.FirstOrDefault(p => p.Id == pedidos.Id);
            if(pedidoEncontrado != null)
            {

                pedidoEncontrado.NombrePaquete = pedidos.NombrePaquete;
                pedidoEncontrado.Peso = pedidos.Peso;
                pedidoEncontrado.FechaCreacion = pedidos.FechaCreacion;
                pedidoEncontrado.EstadoEmpleado = pedidos.EstadoEmpleado;

                pedidoEncontrado.Peso = pedidos.Peso;

                _appContext.SaveChanges();
            }
            return pedidoEncontrado;
        }
    }
}