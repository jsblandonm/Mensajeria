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
    public class HistoricoDetalles : PageModel
    {
        public readonly IRepositorioHistorico _repoHitorico;
        public Historico elHistorico;

        public HistoricoDetalles()
        {
            _repoHitorico = new RepositorioHistorico();
        }

        public void OnGet(int idHistorico)
        {
            elHistorico = _repoHitorico.GetHistorico(idHistorico);
        }
    }
}