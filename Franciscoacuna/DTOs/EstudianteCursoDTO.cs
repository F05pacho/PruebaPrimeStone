using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Franciscoacuna.DTOs
{
    public class EstudianteCursoDTO
    {
        [Required(ErrorMessage = "")]
        [Display(Name = "EstudianteId")]
        public int EstudianteId { get; set; }
        [Required(ErrorMessage = "")]
        [Display(Name = "Estudiante")]
        public EstudianteDTO Estudiante { get; set; }
        [Required(ErrorMessage = "")]
        [Display(Name = "CursoId")]
        public int CursoId { get; set; }
        [Required(ErrorMessage = "")]
        [Display(Name = "Curso")]
        public CursoDTO Curso { get; set; }
    }
}
