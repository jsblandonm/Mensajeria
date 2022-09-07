using System;
using Microsoft.EntityFrameworkCore;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persitencia;
using System.Collections.Generic;
using System.Linq;

namespace DroneOfTheFuture.App.Persistencia
{
    public class RepositorioEmpresaMensajeria : IRepositorioEmpresaMensajeria
    {
        private readonly APPCT _appContext;
        public RepositorioEmpresaMensajeria(APPCT appContext)
        {
            _appContext = appContext;
        }

        public EmpresaMensajeria AddEmpresaMensajeria(EmpresaMensajeria empresaMensajeria)
        {
            var empresaMensajeriaAgregada = _appContext.EmpresaMensajerias.Add(empresaMensajeria);
            _appContext.SaveChanges();
            return empresaMensajeriaAgregada.Entity;
        }

        public void DeleteEmpresaMensajeria(int idEmpresaMensajeria)
        {
            var empresaMensajeriaEncontrada = _appContext.EmpresaMensajerias.FirstOrDefault(em => em.Id == idEmpresaMensajeria);
            if (empresaMensajeriaEncontrada == null)
            {
                return;
            }
            _appContext.EmpresaMensajerias.Remove(empresaMensajeriaEncontrada);
            _appContext.SaveChanges();
        }

        public IEnumerable<EmpresaMensajeria> GetAllEmpresaMensajeria()
        {
            throw new NotImplementedException();
        }

        public EmpresaMensajeria GetEmpresaMensajeria(int idEmpresaMensajeria)
        {
            return _appContext.EmpresaMensajerias.FirstOrDefault(em => em.Id == idEmpresaMensajeria);
        }

        public EmpresaMensajeria UpdateEmpresaMensajeria(EmpresaMensajeria empresaMensajeria)
        {
            var empresaMensajeriaEncontrada = _appContext.EmpresaMensajerias.FirstOrDefault(em => em.Id == empresaMensajeria.Id);
            if (empresaMensajeriaEncontrada != null)
            {
<<<<<<< HEAD
                empresaMensajeriaEncontrada.NombreEmpresa = empresaMensajeria.NombreEmpresa;
                empresaMensajeriaEncontrada.Drieccion = empresaMensajeria.Drieccion;
                empresaMensajeriaEncontrada.Drones = empresaMensajeria.Drones;
=======
>>>>>>> 82f0319ae87c0f74a52d72163b39d34fa0894bc7
                empresaMensajeriaEncontrada.NitEmpresa = empresaMensajeria.NitEmpresa;

                _appContext.SaveChanges();
            }
            return empresaMensajeriaEncontrada;
        }
    }
}