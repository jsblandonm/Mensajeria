using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persistencia;

namespace DroneOfTheFuture.App.FrontEnd.Pages.ClientesPage
{
    public class ClientesEdit : PageModel
    {
        private readonly IRepositorioCliente repositorioCliente;
        private readonly IRepositorioPedido repositorioPedido;
        [BindProperty]
        public Cliente clientes { get; set; }
        [BindProperty]
        public IEnumerable<Pedidos> compras {get;set;}
        public bool est { get; set; }
        public ClientesEdit(IRepositorioCliente repositorioCliente, IRepositorioPedido repositorioPedido)
        {
            this.repositorioCliente = repositorioCliente;
            this.repositorioPedido = repositorioPedido;
        }


        public IActionResult OnGet(int? idCliente, bool estado)
        {
            this.compras = repositorioPedido.GetAllPedido();
            est = estado;
            if (idCliente.HasValue)
            {
                clientes = repositorioCliente.GetCliente(idCliente.Value);
            }
            else
            {
                clientes = new Cliente();
            }


            if (clientes == null)
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
            if (clientes.Id > 0)
            {
                clientes = repositorioCliente.UpdateCliente(clientes);
            }
            else
            {
                repositorioCliente.AddCliente(clientes);
            }
            return Page();
        }
    }
}