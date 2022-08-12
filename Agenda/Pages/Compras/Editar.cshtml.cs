using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Farmacia.Datos;
using Farmacia.Modelos;

using Microsoft.EntityFrameworkCore;




namespace Farmacia.Pages.Compras
{
    public class EditarModel : PageModel
    {

        private readonly ApplicationDbContext _contexto;

        public EditarModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [BindProperty]
        public Compra Compra { get; set; }

       // public ApplicationDbContext Contexto => _contexto;

        public async void OnGet(int id)
        {

        Compra = await _contexto.Compra.FindAsync(id);

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var CompraDesdeDb = await _contexto.Compra.FindAsync(Compra.Id);

                CompraDesdeDb.Nombre = Compra.Nombre;
                CompraDesdeDb.Precio = Compra.Precio;
                CompraDesdeDb.FechaCompra = Compra.FechaCompra;
                CompraDesdeDb.Cantidad = Compra.Cantidad;
                await _contexto.SaveChangesAsync();
                return RedirectToPage("Index");

            }

            else
            {
                return RedirectToPage();


            }

        }

    }
}
