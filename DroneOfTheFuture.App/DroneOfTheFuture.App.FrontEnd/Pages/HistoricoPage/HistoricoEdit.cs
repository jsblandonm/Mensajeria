using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persistencia;

namespace DroneOfTheFuture.App.FrontEnd.Pages.HistoricoPage
{
    public class HistoricoEdit : PageModel
    {
        private readonly IRepositorioHistorico repositorioHistorico;
        [BindProperty]
        public Historico historicos { get; set; }
        public bool est { get; set; }
        public HistoricoEdit(IRepositorioHistorico repositorioHistorico)
        {
            this.repositorioHistorico = repositorioHistorico;
        }


        public IActionResult OnGet(int? idHistorico, bool estado)
        {
            est = estado;
            if (idHistorico.HasValue)
            {
                historicos = repositorioHistorico.GetHistorico(idHistorico.Value);
            }
            else
            {
                historicos = new Historico();
            }


            if (historicos == null)
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
            if (historicos.Id > 0)
            {
                historicos = repositorioHistorico.UpdateHistorico(historicos);
            }
            else
            {
                repositorioHistorico.AddHistorico(historicos);
            }
            return Page();
        }
    }
}