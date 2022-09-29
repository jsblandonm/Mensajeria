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
    public class ReportesEdit : PageModel
    {
        private readonly IRepositorioReporte repositorioReporte;
        private readonly IRepositorioPedido repositorioPedido;
        [BindProperty]
        public Reportes reportes { get; set; }
        [BindProperty]
        public IEnumerable<Pedidos> listapedidos {get;set;}
        public bool est { get; set; }
        public ReportesEdit(IRepositorioReporte repositorioReporte,IRepositorioPedido repositorioPedido)
        {
            this.repositorioReporte = repositorioReporte;
            this.repositorioPedido = repositorioPedido;
        }


        public IActionResult OnGet(int? ReportesId, bool estado)
        {
            this.listapedidos = repositorioPedido.GetAllPedido();
            est = estado;
            if (ReportesId.HasValue)
            {
                reportes = repositorioReporte.GetReportes(ReportesId.Value);
            }
            else
            {
                reportes = new Reportes();
            }


            if (reportes == null)
            {
                return RedirectToPage("./ErrorBusqueda");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (reportes.Id > 0)
            {
                reportes = repositorioReporte.UpdateReportes(reportes);
            }
            else
            {
                repositorioReporte.AddReportes(reportes);
            }
            return Page();
        }
    }
}