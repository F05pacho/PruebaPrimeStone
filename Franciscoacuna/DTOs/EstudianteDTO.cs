using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Franciscoacuna.DTOs
{
    public class EstudianteDTO : EntidadDTO
    {
        [Required(ErrorMessage = "")]
        [Display(Name ="Nombres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "")]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "")]
        [Display(Name = "FechaNacimento ")]
        public DateTime FechaNacimento { get; set; }

        [Required(ErrorMessage = "")]
        [Display(Name = "Genero")]
        public Genero Genero { get; set; }

        [Required(ErrorMessage = "")]
        [Display(Name = "Direcciones ")]
        public IEnumerable<DireccionDTO> Direcciones { get; set; }

        [Required(ErrorMessage = "")]
        [Display(Name = "EstudianteCursos")]
        public IEnumerable<EstudianteCursoDTO> EstudiantesCursos { get; set; }
    }
}
