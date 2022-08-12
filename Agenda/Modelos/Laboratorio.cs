using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Modelos
{
    public class Laboratorio
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El Nombre del Laboratorio es obligatorio")]
        [StringLength(50, ErrorMessage = "{0} el nombre debe tener entre {2} y {1} caracteres", MinimumLength = 4)]
        [Display(Name ="Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "el telefono  es obligatorio ")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "La Direccion es un Campo obligatorio ")]
        [StringLength(50, ErrorMessage = "{0} el nombre debe tener entre {2} y {1} caracteres", MinimumLength = 4)]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El Email es Obligatorio ")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        public bool Estado { get; set; }
    }
}
