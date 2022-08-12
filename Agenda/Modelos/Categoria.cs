using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Modelos
{
    public class Categoria
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre del Empleado  es obligatorio ")]
        [StringLength(50, ErrorMessage = "{0} el nombre debe tener entre {2} y {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La Descripcion de la categoria  es obligatorio ")]
        [StringLength(50, ErrorMessage = "{0} el nombre debe tener entre {2} y {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Descripcion")]
        public string DescripcionCategoria { get; set; }

        [Required(ErrorMessage = "El Laboratorio  es obligatorio ")]
        [StringLength(50, ErrorMessage = "{0} el nombre debe tener entre {2} y {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Laboratorio")]
        public string Laboratorio { get; set; }

        [Required(ErrorMessage = "La fecha  es obligatorio ")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Creacion")]
        public DateTime? FechaCreacion { get; set; }
        public bool Estado { get; set; }

    }
}
