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
    public class EditarModel : PageModel
    {

        private readonly ApplicationDbContext _contexto;

        public EditarModel(ApplicationDbContext contexto)
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
            if (ModelState.IsValid)
            {
                var LaboratorioDesdeDb = await _contexto.Laboratorio.FindAsync(Laboratorio.Id);

                LaboratorioDesdeDb.Nombre = Laboratorio.Nombre;
                LaboratorioDesdeDb.Telefono = Laboratorio.Telefono;              
                LaboratorioDesdeDb.Direccion = Laboratorio.Direccion;
                LaboratorioDesdeDb.Email = Laboratorio.Email;
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
