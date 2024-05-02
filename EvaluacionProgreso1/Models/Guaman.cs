using EvaluacionProgreso1.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluacionProgreso.Models
{
    public class Guaman
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public float Calificacion { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public bool Ecuatoriano { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [ForeignKey("CarreraId")]
        public int? CarreraId { get; set; }
        public Carrera Carrera { get; set; }
    }
}
