using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Farmacia.Datos;
using Farmacia.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Farmacia.Pages.Empleados
{
    public class CrearModel : PageModel
    {

        private readonly ApplicationDbContext _contexto;

        public CrearModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [BindProperty]
        public Empleado Empleado { get; set; }

        public ApplicationDbContext Contexto => _contexto;

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                await _contexto.Empleado.AddAsync(Empleado);
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
