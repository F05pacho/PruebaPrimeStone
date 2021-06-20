using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Franciscoacuna.DTOs
{
    public class EntidadDTO
    {
        [Required(ErrorMessage = "")]
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "")]
        [Display(Name = "EstadoBorrado")]
        public bool EstadoBorrado { get; set; }
        [Required(ErrorMessage = "")]
        [Display(Name = "FechaCreacion")]
        public DateTime FechaCreacion { get; set; }
        [Required(ErrorMessage = "")]
        [Display(Name = "FechaBorrado")]
        public DateTime FechaBorrado { get; set; }
        [Required(ErrorMessage = "")]
        [Display(Name = "FechaActualizacion")]
        public DateTime FechaActualizacion { get; set; }
    }
}
