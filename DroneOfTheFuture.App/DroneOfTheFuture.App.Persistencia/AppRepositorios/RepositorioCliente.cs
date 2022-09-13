using System;
using Microsoft.EntityFrameworkCore;
using DroneOfTheFuture.App.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace DroneOfTheFuture.App.Persistencia
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly AppContexto _appContext;
        public RepositorioCliente(AppContexto appContext)
        {
            _appContext = appContext;
        }
        public RepositorioCliente()
        {
            _appContext = new AppContexto();
        }
        public Cliente AddCliente(Cliente cliente)
        {
            var clienteAgregado = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteAgregado.Entity;
        }
        public void DeleteCliente(int idCliente)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.Id == idCliente);
            if (clienteEncontrado == null)
            {
                return;
            }
            _appContext.Clientes.Remove(clienteEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Cliente> GetAllCliente()
        {
            return _appContext.Clientes;
        }

        public Cliente GetCliente(int idCliente)
        {
            return _appContext.Clientes.FirstOrDefault(c => c.Id == idCliente);
        }

        public Cliente UpdateCliente(Cliente cliente)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.Id == cliente.Id);
            if (clienteEncontrado != null)
            {
                clienteEncontrado.TipoPersona = cliente.TipoPersona;
                clienteEncontrado.Direccion = cliente.Direccion;
                clienteEncontrado.Compras = cliente.Compras;

                _appContext.SaveChanges();
            }
            return clienteEncontrado;
        }
    }
}