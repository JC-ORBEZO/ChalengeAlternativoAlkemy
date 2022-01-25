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
        [Required(ErrorMessage ="El campo Denominación es requerido.")]
        [MaxLength(20)]
        public string Denominacion { get; set; }
        public List<City> Cities { get; set; }
    }
}
