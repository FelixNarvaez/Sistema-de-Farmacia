using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Farmacia.Datos;
using Farmacia.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Farmacia.Pages.Ventas
{
    public class BorrarModel : PageModel
    {

        private readonly ApplicationDbContext _contexto;

        public BorrarModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [BindProperty]
        public Venta Venta { get; set; }

       // public ApplicationDbContext Contexto => _contexto;

        public async void OnGet(int id)
        {

        Venta = await _contexto.Venta.FindAsync(id);

        }

        public async Task<IActionResult> OnPost()
        {
            
                var VentaDesdeDb = await _contexto.Venta.FindAsync(Venta.Id);

                if(VentaDesdeDb==null)
                {
                    return NotFound();
                }

                _contexto.Venta.Remove(VentaDesdeDb);
                await _contexto.SaveChangesAsync();
                return RedirectToPage("Index");

        }

    }
}
