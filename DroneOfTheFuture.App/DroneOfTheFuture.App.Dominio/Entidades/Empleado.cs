using System;

namespace DroneOfTheFuture.App.Dominio
{
    public class Empleado : Persona
    {
        public string TipoPersona {get;set;}
        public int HorasLaboradas{get;set;}
        public Mensajeria  SuEmpresa {get;set;}

    }
}