using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DroneOfTheFuture.App.Dominio;

namespace DroneOfTheFuture.App.Persitencia
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();
        Persona AddPersona(Persona persona);

        Persona UpdatePersona(Persona persona);
        void DeletePersona(int idPersona);
        Persona GetPersona(int idPersona);
    }
}