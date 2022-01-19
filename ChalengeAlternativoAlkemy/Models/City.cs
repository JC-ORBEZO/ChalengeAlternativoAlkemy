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
        [Required]
        [MaxLength(100)]
        public string Denominacion { get; set; }
        [Range(0,5)]
        public int CantidadHabitantes { get; set; }
        [Column(TypeName = "decimal(20, 3)")]
        public decimal SuperficieTotal { get; set; }
        public List<Icon> Icons { get; set; }
    }
}
