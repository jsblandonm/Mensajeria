using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DroneOfTheFuture.App.Dominio;
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

        IEnumerable<EmpresaMensajeria> IRepositorioEmpresaMensajeria.GetAllEmpresaMensajeria()
        {
            return _appContext.EmpresaMensajeria;
        }

        RepositorioEmpresaMensajeria IRepositorioEmpresaMensajeria.AddEmpresaMensajeria(EmpresaMensajeria empresaMensajeria)
        {
            var empresamensajeriaAgregado = _appContext.EmpresaMensajeria.Add(empresaMensajeria);
            _appContext.SaveChanges();
            return empresaMensajeria.Entity;
        }

        EmpresaMensajeria IRepositorioEmpresaMensajeria.UpdateEmpresaMensajeria(EmpresaMensajeria empresaMensajeria)
        {
            var empresamensajeriaEncontrada = _appContext.EmpresaMensajeria.FirstOrDefault(em => em.Id == empresaMensajeria.Id);
            if (empresamensajeriaEncontrada != null)
            {
                empresamensajeriaEncontrada.NombreEmpresa = empresaMensajeria.NombreEmpresa;
                empresaMensajeria.Drieccion = empresaMensajeria.Drieccion;
                empresaMensajeria.Drones = empresaMensajeria.Drones;
                empresaMensajeria.NitEmpresa = empresaMensajeria.NitEmpresa;
                empresaMensajeria.Empleados = empresaMensajeria.Empleados;
                _appContext.SaveChanges();
            }
            return empresamensajeriaEncontrada;
        }
        void IRepositorioEmpresaMensajeria.DeleteEmpresaMensajeria(int idEmpresaMensajeria)
        {
            var empresamensajeriaEncontrada = _appContext.EmpresaMensajeria.FirstOrDefault(em => em.Id == empresaMensajeria.Id);
            if (empresamensajeriaEncontrada == null)
            {
                return;
            }
            _appContext.EmpresaMensajeria.Remove(empresamensajeriaEncontrada);
            _appContext.SaveChanges();
        }
        EmpresaMensajeria IRepositorioEmpresaMensajeria.GetEmpresaMensajeria(int idEmpresaMensajeria)
        {
            return _appContext.EmpresaMensajeria.FirstOrDefault(em => em.Id == empresaMensajeria.Id);

        }
    }
}