using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DroneOfTheFuture.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public string NumeroDeTelefono { get; set; }
        [Required]
        public string Identificacion { get; set; }
    }
}