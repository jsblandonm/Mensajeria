using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DroneOfTheFuture.App.Dominio;

namespace DroneOfTheFuture.App.Persistencia
{
    public interface IRepositorioHistorico
    {
        IEnumerable<Historico> GetAllHistorico();
        Historico AddHistorico(Historico historico);
        Historico UpdateHistorico(Historico historico);
        void DeleteHistorico(int idHistorico);
        Historico GetHistorico(int idHistorico);
    }
}
