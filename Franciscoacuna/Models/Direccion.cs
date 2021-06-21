using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Franciscoacuna.Models
{
    [Table("Direccion")]
    public class Direccion 
    {
        [Column("Direccion")]

        public int Id { get; set; }
        public string StringDireccion { get; set; }
        public TipoDireccion TipoDireccion { get; set; }
        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }

    }
}