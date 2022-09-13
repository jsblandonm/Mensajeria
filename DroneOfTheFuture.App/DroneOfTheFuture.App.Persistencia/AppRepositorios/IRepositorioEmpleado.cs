using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DroneOfTheFuture.App.Dominio;

namespace DroneOfTheFuture.App.Persistencia
{
    public interface IRepositorioEmpleado
    {
        IEnumerable<Empleado> GetAllEmpleado();
        Empleado AddEmpleado(Empleado empleado);
        Empleado UpdateEmpleado(Empleado empleado);
        void DeleteEmpleado(int idEmpleado);
        Empleado GetEmpleado(int idEmpleado);
    }
}