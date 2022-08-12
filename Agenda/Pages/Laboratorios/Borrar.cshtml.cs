using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Farmacia.Datos;
using Farmacia.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Farmacia.Pages.Laboratorios
{
    public class BorrarModel : PageModel
    {

        private readonly ApplicationDbContext _contexto;

        public BorrarModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [BindProperty]
        public Laboratorio Laboratorio { get; set; }

       // public ApplicationDbContext Contexto => _contexto;

        public async void OnGet(int id)
        {

            Laboratorio = await _contexto.Laboratorio.FindAsync(id);

        }

        public async Task<IActionResult> OnPost()
        {
            
                var LaboratorioDesdeDb = await _contexto.Laboratorio.FindAsync(Laboratorio.Id);

                if(LaboratorioDesdeDb == null)
                {
                    return NotFound();
                }

                _contexto.Laboratorio.Update(LaboratorioDesdeDb);
                LaboratorioDesdeDb.Estado = true;
                Laboratorio.Estado = true;
                await _contexto.SaveChangesAsync();
                return RedirectToPage("Index");

        }

    }
}
