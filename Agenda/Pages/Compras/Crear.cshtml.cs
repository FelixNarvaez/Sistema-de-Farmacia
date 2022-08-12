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
namespace Farmacia.Pages.Compras
{
    public class CrearModel : PageModel
    {

        private readonly ApplicationDbContext _contexto;
        public CrearModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;

        }

        [BindProperty]
        public CrearCompraVM CompraVM { get; set; }


        public async Task<IActionResult> OnGet()
        {
            CompraVM = new CrearCompraVM()

            {
                ListaLaboratorio = await _contexto.Laboratorio.ToListAsync(),
                ListaCategorias = await _contexto.Categoria.ToListAsync(),
                ListaEmpleados = await _contexto.Empleado.ToListAsync(),

                Compras = new Modelos.Compra(),



            };


            return Page();

        }



        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _contexto.Compra.AddAsync(CompraVM.Compras);
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

