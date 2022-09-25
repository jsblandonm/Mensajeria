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
    public class ReportesList : PageModel
    {
        public readonly IRepositorioReporte _repoReporte;
        public IEnumerable<Reportes> listaReportes;

        public ReportesList()
        {
            _repoReporte = new RepositorioReporte();
        }

        public void OnGet(int ReportesId)
        {
            listaReportes = _repoReporte.GetAllReporte();
        }
    }
}