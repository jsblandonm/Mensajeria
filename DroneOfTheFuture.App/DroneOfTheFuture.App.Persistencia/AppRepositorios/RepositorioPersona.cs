// using Microsoft.EntityFrameworkCore;
// using System.Collections.Generic;
// using DroneOfTheFuture.App.Dominio;
// using System.Linq;

// namespace DroneOfTheFuture.App.Persistencia
// {
//     public class RepositorioPersona : IRepositorioPersona
//     {
//         private readonly AppContexto _appContext;
//         public RepositorioPersona(AppContexto appContext)
//         {
//             _appContext = appContext;
//         }
//         public RepositorioPersona (){
//             _appContext = new AppContexto();
//         }
//         IEnumerable<Persona> IRepositorioPersona.GetAllPersona()
//         {
//             return _appContext.Personas;
//         }

//         Persona IRepositorioPersona.AddPersona(Persona persona)
//         {
//             var personaAgregada = _appContext.Personas.Add(persona);
//             _appContext.SaveChanges();
//             return personaAgregada.Entity;
//         }

//         Persona IRepositorioPersona.UpdatePersona(Persona persona)
//         {
//             var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id == persona.Id);
//             if (personaEncontrada != null)
//             {
//                 personaEncontrada.Nombre = persona.Nombre;
//                 personaEncontrada.Apellidos = persona.Apellidos;
//                 personaEncontrada.FechaNacimiento = persona.FechaNacimiento;
//                 personaEncontrada.NumeroDeTelefono = persona.NumeroDeTelefono;
//                 personaEncontrada.Identificacion = persona.Identificacion;
//                 personaEncontrada.clientes = persona.clientes;

//                 _appContext.SaveChanges();
//             }
//             return personaEncontrada;
//         }
//         void IRepositorioPersona.DeletePersona(int idPersona)
//         {
//             var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
//             if (personaEncontrada == null)
//             {
//                 return;
//             }
//             _appContext.Personas.Remove(personaEncontrada);
//             _appContext.SaveChanges();
//         }
//         Persona IRepositorioPersona.GetPersona(int idPersona)
//         {
//             return _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
//         }

//     }
// }