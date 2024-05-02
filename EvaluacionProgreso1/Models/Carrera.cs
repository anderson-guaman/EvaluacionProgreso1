using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EvaluacionProgreso1.Models
{
    public class Carrera
    {
        [Key]
        public int Id { get; set; }

        [Required,StringLength(30)]
        [DisplayName("Numero de semestre")]
        public string Nombre_Carrera { get; set; }
        [Required]
        public string Campus {  get; set; }
        [Required]
        [Range(1, 9)]
        public int Numero_Semestre { get; set; }
    }
}
