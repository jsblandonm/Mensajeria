using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DroneOfTheFuture.App.Dominio
{
    public class Cliente : Persona
    {
        [Required]
        public string TipoPersona { get; set; }
        [Required]
        public string Direccion { get; set; }
        // [Required]
        public ICollection<Pedidos> Compras { get; set; }
    }
}