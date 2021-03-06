using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Franciscoacuna.DTOs
{
    public class DireccionDTO
    {
        
        [Required(ErrorMessage = "")]
        [Display(Name = "StringDireccion")]
        public string StringDireccion { get; set; }

        [Required(ErrorMessage = "")]
        [Display(Name = "TipoDireccion")]
        public TipoDireccion TipoDireccion { get; set; }

        [Required(ErrorMessage = "")]
        [Display(Name = "EstudianteId")]
        public int EstudianteId { get; set; }

        [Required(ErrorMessage = "")]
        [Display(Name = "Estudiante")]
        public EstudianteDTO Estudiante { get; set; }
    }
}
