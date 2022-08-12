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
  public class IndexModelEs : PageModel
  {
    private readonly ApplicationDbContext _contexto;

    public IndexModelEs(ApplicationDbContext contexto)
    {
      _contexto = contexto;
    }

    public IEnumerable<Empleado> Empleados { get; set; }

    public async Task OnGet()
    {
      Empleados = await _contexto.Empleado.ToListAsync();


    }


  }
}
