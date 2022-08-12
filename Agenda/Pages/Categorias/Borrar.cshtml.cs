using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Farmacia.Datos;
using Farmacia.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;


namespace Farmacia.Pages.Categorias
{
    public class BorrarModel : PageModel
    {

        private readonly ApplicationDbContext _contexto;

        public BorrarModel(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        [BindProperty]
        public Categoria Categoria { get; set; }

        // public ApplicationDbContext Contexto => _contexto;

        public async void OnGet(int id)
        {

            Categoria = await _contexto.Categoria.FindAsync(id);

        }

        public async Task<IActionResult> OnPost()
        {

            var CategoriaDesdeDb = await _contexto.Categoria.FindAsync(Categoria.Id);
            
            if (CategoriaDesdeDb == null)
            {
                return NotFound();
            }
           
            _contexto.Categoria.Update(CategoriaDesdeDb);
            CategoriaDesdeDb.Estado = true;
            Categoria.Estado = true;
            await _contexto.SaveChangesAsync();
            return RedirectToPage("Index");

        }

    }
}

//    public class Categorias : PageModel
//    {
//        private readonly string CadenaConexion;

//        public CategoriasController(IConfiguration configuration)
//        {
//            CadenaConexion = configuration.GetConnectionString("DefaultConnection");
//        }
//        public IActionResult Index()
//        {
//            return View();
//        }


//        public async Task<IActionResult> Eliminar(int Id)
//        {
//            using (SqlConnection sql = new SqlConnection(CadenaConexion))
//            {
//                using (SqlCommand cmd = new SqlCommand("EliminarCategoria", sql))
//                {
//                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
//                    cmd.Parameters.Add(new SqlParameter("@id_Categoria", Id));
//                    await sql.OpenAsync();
//                    await cmd.ExecuteNonQueryAsync();
//                    return View();
//                }
//            }
//        }
//    }
//}
