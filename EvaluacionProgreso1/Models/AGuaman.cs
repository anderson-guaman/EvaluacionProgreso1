using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvaluacionProgreso1.Models
{
    public class AGuaman
    {
        [Key]
        private int Id;

        private float? Calificacion;
        [Required]
        private string Nombre;

        private bool Ecuatoriano;
        private DateTime FechaNacimiento;
        [Required, ForeignKey("CarreraId")]
        private int? CarreraId;
        private Carrera? Carrera;
    }
}
