using System;
using Microsoft.EntityFrameworkCore;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persitencia;
using System.Collections.Generic;
using System.Linq;


namespace DroneOfTheFuture.App.Persistencia
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly APPCT _appContext;
        public RepositorioCliente(APPCT appContext)
        {
            _appContext = appContext;
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

                _appContext.SaveChanges();
            }
            return clienteEncontrado;
        }
    }
}