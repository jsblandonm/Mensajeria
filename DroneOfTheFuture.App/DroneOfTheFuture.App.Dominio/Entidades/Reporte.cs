using System;

namespace DroneOfTheFuture.App.Dominio
{
    public class Reportes
    {
        public int Id{get;set;}
        public string NombreDelReporte{get;set;}
        public string TemperaturaDelaZona{get;set;}
        public string EstadoDrone{get;set;}
        public string EstadoPaquete{get;set;}
        public DateTime Fecha{get;set;}
        public Pedidos pedidos{get;set;}

    }
}