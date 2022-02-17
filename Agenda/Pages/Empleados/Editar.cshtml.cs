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
    public class EditarModel : PageModel
    {

        private readonly ApplicationDbContext _contexto;

        public EditarModel(ApplicationDbContext contexto)
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
            if (ModelState.IsValid)
            {
                var EmpleadoDesdeDb = await _contexto.Empleado.FindAsync(Empleado.Id);

                EmpleadoDesdeDb.Nombre = Empleado.Nombre;
                EmpleadoDesdeDb.ApellidoPaterno = Empleado.ApellidoPaterno;
                EmpleadoDesdeDb.ApellidoMaterno = Empleado.ApellidoMaterno;
                EmpleadoDesdeDb.Direccion = Empleado.Direccion;
                EmpleadoDesdeDb.Telefono = Empleado.Telefono;
                EmpleadoDesdeDb.Email = Empleado.Email;
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
