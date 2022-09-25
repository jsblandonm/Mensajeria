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
    public class MensajeriaDetalles : PageModel
    {
        private readonly IRepositorioMensajeria repositorioMensajeria;
        public Mensajeria laMensajeria;

        public MensajeriaDetalles()
        {
            repositorioMensajeria = new RepositorioMensajeria();
        }

        public void OnGet(int MensajeriaId)
        {
            laMensajeria = repositorioMensajeria.GetMensajeria(MensajeriaId);
        }
    }
}