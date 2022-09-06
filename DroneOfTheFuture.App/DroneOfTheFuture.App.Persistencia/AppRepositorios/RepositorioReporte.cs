using System;
using Microsoft.EntityFrameworkCore;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persitencia;
using System.Collections.Generic;
using System.Linq;

namespace DroneOfTheFuture.App.Persistencia
{
    public class RepositorioReporte : IRepositorioReporte
    {
        private readonly APPCT _appContext;
        public RepositorioReporte(APPCT appContext)
        {
            _appContext = appContext;
        }

        public Reportes AddReportes(Reportes reportes)
        {
            var reporteAgregado = _appContext.Reporte.Add(reportes);
            _appContext.SaveChanges();
            return reporteAgregado.Entity;
        }

        public void DeleteReportes(int idReportes)
        {
            var reporteEncontrado = _appContext.Reporte.FirstOrDefault(r => r.Id == idReportes);
            if (reporteEncontrado == null)
            {
                return;
            }
            _appContext.Reporte.Remove(reporteEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Reportes> GetAllReportes()
        {
            return _appContext.Reporte;
        }

        public Reportes GetReportes(int idReportes)
        {
            return _appContext.Reporte.FirstOrDefault(r => r.Id == idReportes);
        }

        public Reportes UpdateReportes(Reportes reportes)
        {
            var reporteEncontrado = _appContext.Reporte.FirstOrDefault(r => r.Id == reportes.Id);
            if (reporteEncontrado != null)
            {
                reporteEncontrado.Nombre = reportes.Nombre;
                reporteEncontrado.Temperatura = reportes.Temperatura;
                reporteEncontrado.EstadoDrone = reportes.EstadoDrone;
                reporteEncontrado.EstadoPaquete = reportes.EstadoPaquete;
                reporteEncontrado.Fecha = reportes.Fecha;

                _appContext.SaveChanges();
            }
            return reporteEncontrado;
        }
    }
}