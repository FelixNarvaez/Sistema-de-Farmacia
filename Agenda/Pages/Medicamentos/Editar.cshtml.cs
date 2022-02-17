using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Farmacia.Datos;
using Farmacia.Modelos;

using Microsoft.EntityFrameworkCore;




namespace Farmacia.Pages.Medicamentos
{
    public class EditarModel : PageModel
    {

        private readonly ApplicationDbContext _contexto;

        public EditarModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [BindProperty]
        public Medicamento Medicamento { get; set; }

       // public ApplicationDbContext Contexto => _contexto;

        public async void OnGet(int id)
        {

        Medicamento = await _contexto.Medicamento.FindAsync(id);

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var MedicamentoDesdeDb = await _contexto.Medicamento.FindAsync(Medicamento.Id);

                MedicamentoDesdeDb.Nombre = Medicamento.Nombre;
                MedicamentoDesdeDb.ViaAdministracion = Medicamento.ViaAdministracion;
                MedicamentoDesdeDb.FechaVencimiento = Medicamento.FechaVencimiento;
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
