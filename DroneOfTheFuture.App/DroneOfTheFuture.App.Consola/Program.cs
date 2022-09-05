using System;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persitencia;

namespace DroneOfTheFuture.App.Consola
{
    class Program
    {
        private static  IRepositorioPersona _repoPersona = new RepositorioPersona(new Persitencia.APPCT());
        private static  IRepositorioEmpresaMensajeria _repoEmpresaMensajeria = new RepositorioEmpresaMensajeria(new Persitencia.APPCT());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // AddPersona();
            AddEmpresaMensajeria();
            obtenerPersona(1);
        }

        private static void AddPersona()
        {
            var persona = new Persona
            {
                Nombre = "Sebas",
                Apellidos = "Blandon",
                NumeroTelefono = "1053858423",
                Identificacion = "2555414",
                FechaNacimiento = new DateTime(1997,07,21)
            };
            _repoPersona.AddPersona(persona);
        }
        private static void AddEmpresaMensajeria()
        {
            var empresamensajeria = new EmpresaMensajeria
            {
                NombreEmpresa = "Sol",
                Drieccion = "Calle Wallaby",
                NitEmpresa = "551151",
                Empleados = "252",
                Drones = "10"
            };
        }

        private static void obtenerPersona (int idPersona)
        {
            var personaEncontrada = _repoPersona.GetPersona(idPersona);
            Console.WriteLine(personaEncontrada.Nombre + " " + personaEncontrada.Apellidos + " " + personaEncontrada.NumeroTelefono);
        }
    }
}
