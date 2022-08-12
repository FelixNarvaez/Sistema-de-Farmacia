using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Modelos
{
    public class Compra
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre del Vendedor  es obligatorio ")]
        [StringLength(50, ErrorMessage = "{0} el nombre debe tener entre {2} y {1} caracteres", MinimumLength = 4)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "el precio  es obligatorio ")]
        //[StringLength(50, ErrorMessage = "{0} el precio debe tener entre {2} y {1} digitos", MinimumLength = 4)]
        public string Precio { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Compra")]
        public DateTime? FechaCompra { get; set; }

        [Required(ErrorMessage = "La cantidad es obligatorio ")]
        public int Cantidad { get; set; }

        public int EmpleadoId { get; set; }
        public int CategoriaId { get; set; }
        public int LaboratorioId { get; set; }

        public Empleado Empleado { get; set; }
        public Categoria Categoria { get; set; }
        public Laboratorio Laboratorio { get; set; }
    }
}
