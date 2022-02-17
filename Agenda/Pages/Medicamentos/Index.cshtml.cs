using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Farmacia.Datos;
using Farmacia.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace Farmacia.Pages.Medicamentos
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _contexto;

        public IndexModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Medicamento> Medicamentos { get; set; }

        public async Task OnGet()
        {
             Medicamentos = await _contexto.Medicamento.Include(c => c.Categoria).ToListAsync();
            
        }


    }
}
