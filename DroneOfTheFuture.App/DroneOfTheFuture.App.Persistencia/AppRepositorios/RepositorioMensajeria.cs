using System;
using Microsoft.EntityFrameworkCore;
using DroneOfTheFuture.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace DroneOfTheFuture.App.Persistencia
{
    public class RepositorioMensajeria : IRepositorioMensajeria
    {
        private readonly AppContexto _appContext;
        
        public RepositorioMensajeria(AppContexto appContext)
        {
            _appContext = appContext;
        }
        public RepositorioMensajeria()
        {
            _appContext = new AppContexto();
        }

        public IEnumerable<Mensajeria> GetAllMensajeria()
        {
            return _appContext.Mensajeria;
        }

        public Mensajeria AddMensajeria(Mensajeria mensajeria)
        {
            var MensajeriaEncargada = _appContext.Mensajeria.Add(mensajeria);
            _appContext.SaveChanges();
            return MensajeriaEncargada.Entity;
        }

        public Mensajeria UpdateMensajeria(Mensajeria mensajeria)
        {
            var MensajeriaEncontrada = _appContext.Mensajeria.FirstOrDefault(em => em.Id == mensajeria.Id);
            if (MensajeriaEncontrada != null)
            {
                MensajeriaEncontrada.NombreEmpresa = mensajeria.NombreEmpresa;
                MensajeriaEncontrada.Drieccion = mensajeria.Drieccion;
                MensajeriaEncontrada.Drones = mensajeria.Drones;
                MensajeriaEncontrada.NitEmpresa = mensajeria.NitEmpresa;
                MensajeriaEncontrada.EstadoDrone = mensajeria.EstadoDrone;
                MensajeriaEncontrada.Empleados = mensajeria.Empleados;
                // MensajeriaEncontrada.Clientes = mensajeria.Clientes;

                _appContext.SaveChanges();
            }
            return MensajeriaEncontrada;
        }

        public void DeleteMensajeria(int idMensajeria)
        {
            var MensajeriaEncontrada = _appContext.Mensajeria.FirstOrDefault(em => em.Id == idMensajeria);
            if (MensajeriaEncontrada == null)
            {
                return;
            }
            _appContext.Mensajeria.Remove(MensajeriaEncontrada);
            _appContext.SaveChanges();
        }

        public Mensajeria GetMensajeria(int idMensajeria)
        {
            return _appContext.Mensajeria.Where(em => em.Id == idMensajeria).Include(h => h.Empleados).FirstOrDefault(em => em.Id == idMensajeria);

        }
    }
}
