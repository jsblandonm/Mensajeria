using System;

namespace DroneOfTheFuture.App.Dominio
{
    public class Pedidos
    {
        public int Id{get;set;}
        public string NombrePaquete{get;set;}
        public int Peso{get;set;}
        public DateTime FechaCreacion{get;set;}

        public string EstadoEmpleado{get;set;}

        public Empleado Empleados {get;set;}

        public Cliente Cliente {get;set;}
        public EmpresaMensajeria EmpresaMensajeria {get;set;}
        
    }
}