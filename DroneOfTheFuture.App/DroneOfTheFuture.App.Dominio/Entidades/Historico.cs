using System;

namespace DroneOfTheFuture.App.Dominio
{
    public class Historico
    {
        public int Id {get;set;}
        public string Satisfacioncliente {get;set;}
        public Reportes SusReportes{get;set;}
        public Empleado SusEmpleados{get;set;}
    }
}