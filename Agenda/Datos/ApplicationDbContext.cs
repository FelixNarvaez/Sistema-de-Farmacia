using Farmacia.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Datos
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria>Categoria { get; set; }

        public DbSet<Empleado> Empleado { get; set; }

        public DbSet<Medicamento> Medicamento { get; set; }

        public DbSet<Venta> Venta { get; set; }
        

    }


}

