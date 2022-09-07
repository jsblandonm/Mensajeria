using System;
using Microsoft.EntityFrameworkCore;
using DroneOfTheFuture.App.Dominio;
using System.Collections.Generic;
using System.Linq;
using DroneOfTheFuture.App.Persitencia;

namespace DroneOfTheFuture.App.Persistencia
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
        private readonly APPCT _appContext;
        public RepositorioEmpleado(APPCT appContext)
        {
            _appContext = appContext;
        }
        public Empleado AddEmpleado(Empleado empleado)
        {
            var empleadoAgregado = _appContext.Empleados.Add(empleado);
            _appContext.SaveChanges();
            return empleadoAgregado.Entity;
        }

        public void DeleteEmpleado(int idEmpleado)
        {
            var empleadoEncontrado = _appContext.Empleados.FirstOrDefault(e => e.Id == idEmpleado);
            if (empleadoEncontrado == null)
            {
                return;
            }
            _appContext.Empleados.Remove(empleadoEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Empleado> GetAllEmpleados()
        {
            return _appContext.Empleados;
        }

        public Empleado GetEmpleado(int idEmpleado)
        {
            return _appContext.Empleados.FirstOrDefault(e => e.Id == idEmpleado);
        }

        public Empleado UpdateEmpleado(Empleado empleado)
        {
            var empleadoEncontrado = _appContext.Empleados.FirstOrDefault(e => e.Id == empleado.Id);
            if (empleadoEncontrado != null)
            {
                empleadoEncontrado.TipoPersona = empleado.TipoPersona;
                empleadoEncontrado.HorasLaboradas = empleado.HorasLaboradas;

                _appContext.SaveChanges();
            }
            return empleadoEncontrado;
        }
    }
}