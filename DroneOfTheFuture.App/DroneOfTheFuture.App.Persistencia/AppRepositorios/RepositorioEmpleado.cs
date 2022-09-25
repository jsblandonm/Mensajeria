using System;
using Microsoft.EntityFrameworkCore;
using DroneOfTheFuture.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace DroneOfTheFuture.App.Persistencia
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
        private readonly AppContexto _appContext;
        public RepositorioEmpleado(AppContexto appContext)
        {
            _appContext = appContext;
        }
        public RepositorioEmpleado()
        {
            _appContext = new AppContexto();
        }
        public Empleado AddEmpleado(Empleado empleado)
        {
            var empleadoAgregado = _appContext.Empleado.Add(empleado);
            _appContext.SaveChanges();
            return empleadoAgregado.Entity;
        }

        public void DeleteEmpleado(int idEmpleado)
        {
            var empleadoEncontrado = _appContext.Empleado.FirstOrDefault(e => e.Id == idEmpleado);
            if (empleadoEncontrado == null)
            {
                return;
            }
            _appContext.Empleado.Remove(empleadoEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Empleado> GetAllEmpleado()
        {
            return _appContext.Empleado;
        }

        public Empleado GetEmpleado(int idEmpleado)
        {
            return _appContext.Empleado.Where(e => e.Id == idEmpleado).Include(e => e.SuEmpresa).Include(e => e.losPedidos).FirstOrDefault();
        }

        public Empleado UpdateEmpleado(Empleado empleado)
        {
            var empleadoEncontrado = _appContext.Empleado.FirstOrDefault(e => e.Id == empleado.Id);
            if (empleadoEncontrado != null)
            {
                empleadoEncontrado.Nombre = empleado.Nombre;
                empleadoEncontrado.Apellidos = empleado.Apellidos;
                empleadoEncontrado.FechaNacimiento = empleado.FechaNacimiento;
                empleadoEncontrado.NumeroDeTelefono = empleado.NumeroDeTelefono;
                empleadoEncontrado.Identificacion = empleado.Identificacion;
                empleadoEncontrado.TipoPersona = empleado.TipoPersona;
                empleadoEncontrado.HorasLaboradas = empleado.HorasLaboradas;
                empleadoEncontrado.SuEmpresa = empleado.SuEmpresa;
                empleadoEncontrado.historico = empleado.historico;
                empleadoEncontrado.losPedidos = empleado.losPedidos;
                _appContext.SaveChanges();
            }
            return empleadoEncontrado;
        }
    }
}