using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Farmacia.Datos;
using Farmacia.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Farmacia.Pages.Empleados
{
    public class BorrarModel : PageModel
    {

        private readonly ApplicationDbContext _contexto;

        public BorrarModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [BindProperty]
        public Empleado Empleado { get; set; }

       // public ApplicationDbContext Contexto => _contexto;

        public async void OnGet(int id)
        {

        Empleado = await _contexto.Empleado.FindAsync(id);

        }

        public async Task<IActionResult> OnPost()
        {
            
                var EmpleadoDesdeDb = await _contexto.Empleado.FindAsync(Empleado.Id);

                if(EmpleadoDesdeDb==null)
                {
                    return NotFound();
                }
                
                _contexto.Empleado.Update(EmpleadoDesdeDb);
                EmpleadoDesdeDb.Estado = true;
                Empleado.Estado = true;
            await _contexto.SaveChangesAsync();
                return RedirectToPage("Index");

        }

    }
}
