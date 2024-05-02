using System.ComponentModel.DataAnnotations;

namespace EvaluacionProgreso1.Models
{
    public class Carrera
    {
        [Key]
        public int Id { get; set; }
        [Required,StringLength(30)]
        public string Nombre_Carrera { get; set; }
        [Required]
        public string Campus {  get; set; }
        [Required]
        public int Numero_Semestre { get; set; }
    }
}
