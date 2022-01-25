using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChalengeAlternativoAlkemy.Models
{
    public class Icon
    {
        [Key]
        public int Id { get; set; }
        [Url]
        public string Imagen { get; set; }
        [Required(ErrorMessage ="El campo Denominación es requerido")]
        [MaxLength(150)]
        public string Denominacion { get; set; }
        [Column(TypeName = "Date")]
        public DateTime FechaCreacion { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Altura { get; set; }
        public string Historia { get; set; }
        public List<City> Cities { get; set; }
    }
}
