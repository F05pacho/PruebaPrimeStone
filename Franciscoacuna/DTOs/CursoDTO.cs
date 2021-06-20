using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Franciscoacuna.DTOs
{
    public class CursoDTO
    {
        [Required(ErrorMessage = "")]
        [Display(Name = "CodigoCurso")]
        public string CodigoCurso { get; set; }

        [Required(ErrorMessage = "")]
        [Display(Name = "NombreCurso")]
        public string NombreCurso { get; set; }

        [Required(ErrorMessage = "")]
        [Display(Name = "FechaInicio")]
        public DateTime FechaInicio { get; set; }

        [Required(ErrorMessage = "")]
        [Display(Name = "FechaFin")]
        public DateTime FechaFin { get; set; }

        [Required(ErrorMessage = "")]
        [Display(Name = "EstudiantesCursos")]
        public IEnumerable<EstudianteCursoDTO> EstudiantesCursos { get; set; }
    }
}
