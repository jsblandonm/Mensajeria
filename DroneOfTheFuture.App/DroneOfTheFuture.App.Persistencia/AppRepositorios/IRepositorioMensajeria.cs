using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DroneOfTheFuture.App.Dominio;

namespace DroneOfTheFuture.App.Persistencia
{
    public interface IRepositorioMensajeria
    {
        IEnumerable<Mensajeria> GetAllMensajeria();
        Mensajeria AddMensajeria (Mensajeria mensajeria);
        Mensajeria UpdateMensajeria(Mensajeria mensajeria);
        void DeleteMensajeria (int idMensajeria);
        Mensajeria GetMensajeria(int idMensajeria);
    }
}