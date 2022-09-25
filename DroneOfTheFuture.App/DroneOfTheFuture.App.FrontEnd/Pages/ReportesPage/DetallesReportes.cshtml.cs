using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persistencia;

namespace DroneOfTheFuture.App.FrontEnd.Pages.ReportesPage
{
    public class DetallesReportes : PageModel
    {
        public readonly IRepositorioReporte _repoReporte;
        public Reportes elReporte;

        public DetallesReportes()
        {
            _repoReporte = new RepositorioReporte();
        }

        public void OnGet(int ReportesId)
        {
            elReporte = _repoReporte.GetReportes(ReportesId);
        }
    }
}