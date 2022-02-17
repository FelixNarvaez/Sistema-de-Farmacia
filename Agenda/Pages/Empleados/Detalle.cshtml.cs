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
  public class DetalleModel : PageModel
  {


    private readonly ApplicationDbContext _contexto;



    public DetalleModel(ApplicationDbContext contexto)
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

  }
}

