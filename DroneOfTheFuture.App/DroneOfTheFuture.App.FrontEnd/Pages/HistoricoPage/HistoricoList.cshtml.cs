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
    public class HistoricoList : PageModel
    {
        private readonly IRepositorioHistorico repositorioHistorico;
        [BindProperty]
        public IEnumerable<Historico> listaHistoricos {get;set;}

        public HistoricoList(IRepositorioHistorico repositorioHistorico)
        {
            this.repositorioHistorico = repositorioHistorico;
        }

        public void OnGet()
        {
            listaHistoricos = repositorioHistorico.GetAllHistorico();
        }
    }
}