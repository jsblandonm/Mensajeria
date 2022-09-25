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
    public class DetallesPedido : PageModel
    {
        public readonly IRepositorioPedido _repoPedido;
        public Pedidos elPedido;

        public DetallesPedido()
        {
            _repoPedido = new RepositorioPedidos();
        }

        public void OnGet(int pedidosId)
        {
            elPedido = _repoPedido.GetPedidos(pedidosId);
        }
    }
}