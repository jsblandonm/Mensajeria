using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DroneOfTheFuture.App.Dominio
{
    public class Empleado : Persona
    {
        [Required]
        public string TipoPersona { get; set; }
        [Required]
        public int HorasLaboradas { get; set; }
        [Required]
        public int MensajeriaId { get; set; }
        public Mensajeria SuEmpresa { get; set; }
        // [Required]
        public int HistoricoId { get; set; }
        public Historico historico { get; set; }
        // [Required]
        public ICollection<Pedidos> losPedidos { get; set; }

    }
}