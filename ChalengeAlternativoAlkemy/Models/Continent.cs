using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChalengeAlternativoAlkemy.Models
{
    public class Continent
    {
        [Key]
        public int Id { get; set; }
        [Url]
        public string Imagen { get; set; }
        [Required]
        [MaxLength(20)]
        public string Denominacion { get; set; }
        public List<City> Cities { get; set; }
    }
}
