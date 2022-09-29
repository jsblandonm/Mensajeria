using System;

namespace DroneOfTheFuture.App.Dominio
{
    public class Pedidos
    {
        public int Id{get;set;}
        public string NombreDelPaquete{get;set;}
        public int Peso{get;set;}
        public DateTime FechaCreacion{get;set;}
        public string EstadoDelPedido{get;set;}
        public Empleado SuEncargado {get;set;}
        public Cliente SuComprador {get;set;}
        public Mensajeria Mensajeria {get;set;}
    }
}