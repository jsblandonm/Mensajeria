using System;

namespace DroneOfTheFuture.App.Dominio
{
    public class Historico
    {
        public int Id {get;set;}
        public string Satisfacioncliente {get;set;}
        public Reportes Reportes{get;set;}
        public Empleado Empleados{get;set;}
    }
}