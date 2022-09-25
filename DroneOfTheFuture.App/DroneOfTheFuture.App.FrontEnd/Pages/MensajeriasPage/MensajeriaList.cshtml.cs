using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persistencia;

namespace DroneOfTheFuture.App.FrontEnd.Pages.MensajeriasPage
{
    public class MensajeriaList : PageModel
    {
        private readonly IRepositorioMensajeria repositorioMensajeria;
        public IEnumerable<Mensajeria> listaMensajeria;

        public MensajeriaList()
        {
            repositorioMensajeria = new RepositorioMensajeria();
        }

        public void OnGet(int MensajeriaId)
        {
            listaMensajeria = repositorioMensajeria.GetAllMensajeria();
        }
    }
}