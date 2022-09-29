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
    public class PedidosList : PageModel
    {
        public readonly IRepositorioPedido _repoPedido;
        [BindProperty]

        public IEnumerable<Pedidos> listaPedidos { get; set; }
        public bool crear { get; set; }
        public bool editar { get; set; }

        public PedidosList()
        {
            _repoPedido = new RepositorioPedidos();
        }

        public void OnGet(int pedidosId)
        {
            listaPedidos = _repoPedido.GetAllPedido();
            crear = true;
            editar = false;
        }
    }
}