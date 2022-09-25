using System;
using Microsoft.EntityFrameworkCore;
using DroneOfTheFuture.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace DroneOfTheFuture.App.Persistencia
{
    public class RepositorioReporte : IRepositorioReporte
    {
        private readonly AppContexto _appContext;
        public RepositorioReporte(AppContexto appContext)
        {
            _appContext = appContext;
        }
        public RepositorioReporte (){
            _appContext = new AppContexto();
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

        public IEnumerable<Reportes> GetAllReporte()
        {
            return _appContext.Reporte;
        }

        public Reportes GetReportes(int idReportes)
        {
            return _appContext.Reporte.Where(r => r.Id == idReportes).Include(r => r.pedidos).FirstOrDefault();
        }

        public Reportes UpdateReportes(Reportes reportes)
        {
            var reporteEncontrado = _appContext.Reporte.FirstOrDefault(r => r.Id == reportes.Id);
            if (reporteEncontrado != null)
            {
<<<<<<< HEAD
                reporteEncontrado.NombreDelReporte = reportes.NombreDelReporte;
                reporteEncontrado.TemperaturaDelaZona = reportes.TemperaturaDelaZona;
                reporteEncontrado.EstadoDrone = reportes.EstadoDrone;
                reporteEncontrado.EstadoPaquete = reportes.EstadoPaquete;
                reporteEncontrado.Fecha = reportes.Fecha;
                reporteEncontrado.pedidos = reportes.pedidos;
=======
                reporteEncontrado.Nombre = reportes.Nombre;
                reporteEncontrado.Temperatura = reportes.Temperatura;
                reporteEncontrado.EstadoDrone = reportes.EstadoDrone;
                reporteEncontrado.EstadoPaquete = reportes.EstadoPaquete;
                reporteEncontrado.Fecha = reportes.Fecha;

>>>>>>> 18b9cac3539ee569ac6073039bbabfd5195364ee
                _appContext.SaveChanges();
            }
            return reporteEncontrado;
        }
    }
}