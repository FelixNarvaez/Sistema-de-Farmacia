using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Farmacia.Modelos
{
    public class Usario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Email es Obligatorio ")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La Clave es Obligatorio ")]
        [Display(Name = "Contraseña")]
        public string Clave { get; set; }
        public string ConfirmarClave { get; set; }
    }
}
