using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Franciscoacuna.Models
{
    [Table("Estudiante")]
    public class Estudiante
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimento { get; set; }
        public Genero Genero { get; set; }
        public IEnumerable<Direccion> Direcciones { get; set; }
        public IEnumerable<EstudianteCurso> EstudiantesCursos { get; set; }
    }
}
