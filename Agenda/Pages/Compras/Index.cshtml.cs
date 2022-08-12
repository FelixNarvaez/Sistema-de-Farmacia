using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Farmacia.Datos;
using Farmacia.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace Farmacia.Pages.Compras
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _contexto;

        public IndexModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Compra> Compras { get; set; }
        
        public async Task OnGet()
        {
            Compras = await _contexto.Compra.Include(c => c.Laboratorio).ToListAsync();
            Compras = await _contexto.Compra.Include(c => c.Categoria).ToListAsync();
            Compras = await _contexto.Compra.Include(c => c.Empleado).ToListAsync();

        }


    }
}
