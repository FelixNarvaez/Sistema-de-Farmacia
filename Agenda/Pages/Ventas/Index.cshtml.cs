using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Farmacia.Datos;
using Farmacia.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace Farmacia.Pages.Ventas
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _contexto;

        public IndexModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<Venta> Ventas { get; set; }
        
        public async Task OnGet()
        {
            Ventas = await _contexto.Venta.Include(c => c.Medicamento).ToListAsync();
            Ventas = await _contexto.Venta.Include(c => c.Categoria).ToListAsync();
            Ventas = await _contexto.Venta.Include(c => c.Empleado).ToListAsync();
            
        }


    }
}
