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
    public class MensajeriaEdit : PageModel
    {
        private readonly IRepositorioMensajeria repositorioMensajeria;
        [BindProperty]
        public Mensajeria lamensajeria { get; set; }
        public bool est { get; set; }
        public MensajeriaEdit(IRepositorioMensajeria repositorioMensajeria)
        {
            this.repositorioMensajeria = repositorioMensajeria;
        }


        public IActionResult OnGet(int? MensajeriaId, bool estado)
        {
            est = estado;
            if (MensajeriaId.HasValue)
            {
                lamensajeria = repositorioMensajeria.GetMensajeria(MensajeriaId.Value);
            }
            else
            {
                lamensajeria = new Mensajeria();
            }


            if (lamensajeria == null)
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
            if (lamensajeria.Id > 0)
            {
                lamensajeria = repositorioMensajeria.UpdateMensajeria(lamensajeria);
            }
            else
            {
                repositorioMensajeria.AddMensajeria(lamensajeria);
            }
            return Page();
        }
    }
}