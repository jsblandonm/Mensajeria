using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DroneOfTheFuture.App.Dominio;

namespace DroneOfTheFuture.App.Persistencia
{
    public interface IRepositorioReporte
    {
        IEnumerable<Reportes> GetAllReporte();
        Reportes AddReportes (Reportes reporte);
        Reportes UpdateReportes (Reportes reporte);
        void DeleteReportes (int idReportes);
        Reportes GetReportes (int idReportes);
    }
}