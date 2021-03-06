using System;
using System.ComponentModel.DataAnnotations;

namespace Franciscoacuna.Models
{
    public abstract class Entidad
    {
        [Key]
        public int Id { get; set; }
        public bool EstadoBorrado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaBorrado { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
