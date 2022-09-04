using System;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persitencia;

namespace DroneOfTheFuture.App.Consola
{
    class Program
    {
        private static  IRepositorioPersona _repoPersona = new RepositorioPersona(new Persitencia.APPCT());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // AddPersona();
            obtenerPersona(1);
        }

        private static void AddPersona()
        {
            var persona = new Persona
            {
                Nombre = "Sebas",
                Apellidos = "Blandon",
                NumeroTelefono = "515151",
                Identificacion = "4816165",
                FechaNacimiento = new DateTime(1997,07,21)
            };
            _repoPersona.AddPersona(persona);
        }

        private static void obtenerPersona (int idPersona)
        {
            var personaEncontrada = _repoPersona.GetPersona(idPersona);
            Console.WriteLine(personaEncontrada.Nombre + " " + personaEncontrada.Apellidos + " " + personaEncontrada.NumeroTelefono);
        }
    }
}
