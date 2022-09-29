using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using DroneOfTheFuture.App.Dominio;
using DroneOfTheFuture.App.Persistencia;

namespace DroneOfTheFuture.App.FrontEnd.Pages.EmpleadosPage
{
    public class EmpleadosEdit : PageModel
    {
        private readonly IRepositorioEmpleado repositorioEmpleado;
        private readonly IRepositorioMensajeria repositorioMensajeria;
        private readonly IRepositorioHistorico repositorioHistorico;
        [BindProperty]
        public Empleado empleados { get; set; }
        [BindProperty]
        public IEnumerable<Mensajeria> listadeMenajerias { get; set; }
        [BindProperty]
        public IEnumerable<Historico> losHistoricos {get;set;}
        // [BindProperty]
        // public Mensajeria lamensajeria { get; set; }
        // [BindProperty]
        // public Historico elhistorico {get;set;}
        public bool est { get; set; }
        public EmpleadosEdit(IRepositorioEmpleado repositorioEmpleado, IRepositorioMensajeria repositorioMensajeria, IRepositorioHistorico repositorioHistorico)
        {
            this.repositorioEmpleado = repositorioEmpleado;
            this.repositorioMensajeria = repositorioMensajeria;
            this.repositorioHistorico = repositorioHistorico;
        }


        public IActionResult OnGet(int? EmpleadoId, bool estado)
        {
            this.listadeMenajerias = repositorioMensajeria.GetAllMensajeria();
            this.losHistoricos = repositorioHistorico.GetAllHistorico();
            est = estado;
            if (EmpleadoId.HasValue)
            {
                empleados = repositorioEmpleado.GetEmpleado(EmpleadoId.Value);
            }
            else
            {
                empleados = new Empleado();
            }


            if (empleados == null)
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
            if (empleados.Id > 0)
            {
                

                empleados = repositorioEmpleado.UpdateEmpleado(empleados);
            }
            else
            {
            
                repositorioEmpleado.AddEmpleado(empleados);

            }
            return Page();
        }
    }
}