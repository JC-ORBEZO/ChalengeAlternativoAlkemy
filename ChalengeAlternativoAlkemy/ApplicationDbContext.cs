using ChalengeAlternativoAlkemy.Models;
using Microsoft.EntityFrameworkCore;

namespace ChalengeAlternativoAlkemy
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Continent> Continents { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Icon> Icons { get; set; }
    }
}
