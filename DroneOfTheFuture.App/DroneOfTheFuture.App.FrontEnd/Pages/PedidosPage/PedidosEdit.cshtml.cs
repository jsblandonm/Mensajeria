using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persistencia;

namespace DroneOfTheFuture.App.FrontEnd.Pages.PedidosPage
{
    public class PedidosEdit : PageModel
    {
        private readonly IRepositorioPedido repositorioPedido;
        private readonly IRepositorioMensajeria repositorioMensajeria;
        [BindProperty]
        public Pedidos pedidos { get; set; }
        [BindProperty]
        public Mensajeria lamenasjeria {get;set;}
        public bool est { get; set; }
        public PedidosEdit(IRepositorioPedido repositorioPedido,IRepositorioMensajeria repositorioMensajeria)
        {
            this.repositorioPedido = repositorioPedido;
            this.repositorioMensajeria  = repositorioMensajeria;
        }


        public IActionResult OnGet(int? pedidosId,int MensajeriaId, bool estado)
        {
            lamenasjeria = repositorioMensajeria.GetMensajeria(MensajeriaId);
            est = estado;
            if (pedidosId.HasValue)
            {
                Console.WriteLine("Enrtro");
                pedidos = repositorioPedido.GetPedidos(pedidosId.Value);
            }
            else
            {
                pedidos = new Pedidos();
            }


            if (pedidos == null)
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
            if (pedidos.Id > 0)
            {
                pedidos = repositorioPedido.UpdatePedidos(pedidos);
            }
            else
            {
                repositorioPedido.AddPedido(pedidos);
            }
            return Page();
        }
    }
}