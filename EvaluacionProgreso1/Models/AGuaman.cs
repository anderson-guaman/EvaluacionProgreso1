using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluacionProgreso1.Models
{
    public class AGuaman
    {
        [Key]
        private int Id { get; set; }
        
        private float? Calificacion {  get; set; }
        [Required]
        private string Nombre { get; set; }
        
        private bool Ecuatoriano { get; set; }

        [Required]
        private DateTime FechaNacimiento;


        [Required, ForeignKey("CarreraId")]
        private int? CarreraId { get; set; }
        private Carrera? Carrera {  get; set; }
    }
}
