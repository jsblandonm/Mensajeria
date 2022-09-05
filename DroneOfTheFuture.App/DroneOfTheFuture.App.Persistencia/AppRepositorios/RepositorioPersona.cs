using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DroneOfTheFuture.App.Dominio;
using System.Linq;

namespace DroneOfTheFuture.App.Persitencia
{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly APPCT _appContext;
        public RepositorioPersona(APPCT appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {
            return _appContext.Personas;
        }

        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAgregada = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAgregada.Entity;
        }

        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id == persona.Id);
            if (personaEncontrada != null)
            {
                personaEncontrada.Nombre = persona.Nombre;
                personaEncontrada.Apellidos = persona.Apellidos;
                personaEncontrada.FechaNacimiento = persona.FechaNacimiento;
                personaEncontrada.NumeroTelefono = persona.NumeroTelefono;
                personaEncontrada.Identificacion = persona.Identificacion;
                personaEncontrada.TipoPersona = Cliente.TipoPersona;
                personaEncontrada.Direccion = Cliente.Direccion;

                _appContext.SaveChanges();
            }
            return personaEncontrada;
        }
        void IRepositorioPersona.DeletePersona(int idPersona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
            if (personaEncontrada == null)
            {
                return;
            }
            _appContext.Personas.Remove(personaEncontrada);
            _appContext.SaveChanges();
        }
        Persona IRepositorioPersona.GetPersona(int idPersona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
        }
    }
}