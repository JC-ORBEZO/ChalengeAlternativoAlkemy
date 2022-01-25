using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChalengeAlternativoAlkemy.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [Url]
        public string Imagen { get; set; }
        [Required(ErrorMessage ="El campo Denominación es requerido.")]
        [MaxLength(100)]
        public string Denominacion { get; set; }
        public int CantidadHabitantes { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal SuperficieTotal { get; set; }
        public List<Icon> Icons { get; set; }
    }
}
