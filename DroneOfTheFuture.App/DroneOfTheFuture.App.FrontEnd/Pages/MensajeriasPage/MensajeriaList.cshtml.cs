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
        [BindProperty]
        public IEnumerable<Mensajeria> listaMensajeria { get; set; }
        public bool crear { get; set; }
        public bool editar { get; set; }

        public MensajeriaList(IRepositorioMensajeria repositorioMensajeria)
        {
            this.repositorioMensajeria = repositorioMensajeria;
        }

        public void OnGet()
        {
            listaMensajeria = repositorioMensajeria.GetAllMensajeria();
            crear = true;
            editar = false;
        }
    }
}