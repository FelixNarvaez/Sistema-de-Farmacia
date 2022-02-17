using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Farmacia.Modelos
{
    public class Medicamento
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Nombre del medicamento  es obligatorio ")]
        [StringLength(50, ErrorMessage = "{0} el nombre debe tener entre {2} y {1} caracteres", MinimumLength = 4)]
       
        public string Nombre { get; set; }

        [Required(ErrorMessage = "EL Campo es obligatorio ")]
        [StringLength(50, ErrorMessage = "{0} el campo debe tener entre {2} y {1} caracteres", MinimumLength = 4)]
        public string ViaAdministracion{ get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Vencimiento")]
        public DateTime? FechaVencimiento { get; set; }
//estas 3 lineas de codigo hay una relacion de uno a mucho una categoria tiene muchos contactos
        [Required]
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

    }
}
