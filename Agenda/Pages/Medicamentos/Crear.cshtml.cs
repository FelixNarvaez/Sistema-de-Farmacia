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
namespace Farmacia.Pages.Medicamentos
{
    public class CrearModel : PageModel
    {

        private readonly ApplicationDbContext _contexto;
        public CrearModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;

        }

        [BindProperty]
        public CrearMedicamentoVM MedicamentoVM { get; set; }


        public async Task<IActionResult> OnGet()
        {
            MedicamentoVM = new CrearMedicamentoVM()

            {
                ListaCategorias = await _contexto.Categoria.ToListAsync(),
                Medicamento=new Modelos.Medicamento()

            };


            return Page();

        }



        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _contexto.Medicamento.AddAsync(MedicamentoVM.Medicamento);
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

