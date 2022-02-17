using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Farmacia.Modelos
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre del Cliente  es obligatorio ")]
        [StringLength(50, ErrorMessage = "{0} el nombre debe tener entre {2} y {1} caracteres", MinimumLength = 4)]
       
        public string Nombre { get; set; }

        [Required(ErrorMessage = "el precio  es obligatorio ")]
        //[StringLength(50, ErrorMessage = "{0} el precio debe tener entre {2} y {1} digitos", MinimumLength = 4)]
        public string Precio { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Venta")]
        public DateTime? FechaVenta { get; set; }
//estas 3 lineas de codigo hay una relacion de uno a mucho una categoria tiene muchos contactos
        [Required]
        public int CategoriaId { get; set; }
        public int MedicamentoId { get; set; }
        public int EmpleadoId { get; set; }

        public Categoria Categoria { get; set; }
        public Medicamento Medicamento { get; set; }
        public Empleado Empleado { get; set; }

    }
}
