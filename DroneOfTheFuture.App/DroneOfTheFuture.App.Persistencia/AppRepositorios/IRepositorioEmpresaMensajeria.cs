using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DroneOfTheFuture.App.Dominio;

namespace DroneOfTheFuture.App.Persitencia
{
    public interface IRepositorioEmpresaMensajeria
    {
        IEnumerable<EmpresaMensajeria> GetAllEmpresaMensajeria();
        EmpresaMensajeria AddEmpresaMensajeria(EmpresaMensajeria empresaMensajeria);
        EmpresaMensajeria UpdateEmpresaMensajeria(EmpresaMensajeria empresaMensajeria);
        void DeleteEmpresaMensajeria(int idEmpresaMensajeria);
        EmpresaMensajeria GetEmpresaMensajeria(int idEmpresaMensajeria);
    }
}