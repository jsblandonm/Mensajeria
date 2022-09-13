using System;
using System.Collections.Generic;

namespace DroneOfTheFuture.App.Dominio
{
        public class Persona
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Apellidos {get;set;}
        public DateTime FechaNacimiento {get;set;}
        public string NumeroDeTelefono {get;set;}
        public string Identificacion {get;set;}
        public ICollection<Cliente> LosClientes{get;set;}
        public ICollection<Empleado> empleados{get;set;}

    }
}