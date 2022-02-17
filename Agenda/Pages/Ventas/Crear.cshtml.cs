using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Farmacia.Datos;
using Farmacia.Modelos;
using Farmacia.Modelos.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
namespace Farmacia.Pages.Ventas
{
    public class CrearModel : PageModel
    {

        private readonly ApplicationDbContext _contexto;
        public CrearModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;

        }

        [BindProperty]
        public CrearVentaVM VentaVM { get; set; }


        public async Task<IActionResult> OnGet()
        {
            VentaVM = new CrearVentaVM()

            {
                ListaMedicamento = await _contexto.Medicamento.ToListAsync(),
                ListaCategorias = await _contexto.Categoria.ToListAsync(),
                ListaEmpleados = await _contexto.Empleado.ToListAsync(),

                Ventas = new Modelos.Venta(),



            };


            return Page();

        }



        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _contexto.Venta.AddAsync(VentaVM.Ventas);
                await _contexto.SaveChangesAsync();
                return RedirectToPage("Index");

            }

            else
            {
                return Page();


            }

        }






    }
}

