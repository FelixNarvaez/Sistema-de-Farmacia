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
    public class BorrarModel : PageModel
    {

        private readonly ApplicationDbContext _contexto;

        public BorrarModel(ApplicationDbContext contexto)
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
            
                var CompraDesdeDb = await _contexto.Compra.FindAsync(Compra.Id);

                if(CompraDesdeDb==null)
                {
                    return NotFound();
                }

                _contexto.Compra.Remove(CompraDesdeDb);
                await _contexto.SaveChangesAsync();
                return RedirectToPage("Index");

        }

    }
}
