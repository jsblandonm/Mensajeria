using System;
using System.Collections.Generic;

namespace DroneOfTheFuture.App.Dominio
{
    public class EmpresaMensajeria
    {
        public int Id {get;set;}
        public string NombreEmpresa{get;set;}
        public string Drieccion{get;set;}
        public int Drones{get;set;}
        public string NitEmpresa{get;set;}
        public IList<Empleado> Empleados {get;set;}


    }
}