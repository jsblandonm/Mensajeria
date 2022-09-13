using System;
using System.Collections.Generic;

namespace DroneOfTheFuture.App.Dominio
{
    public class Mensajeria
    {
        public int Id {get;set;}
        public string NombreEmpresa{get;set;}
        public string Drieccion{get;set;}
        public int Drones{get;set;}
        public string NitEmpresa{get;set;}
        public string EstadoDrone{get;set;}
        public ICollection<Empleado> Empleados  {get;set;}
        // public ICollection<Cliente> Clientes {get;set;}


    }
}