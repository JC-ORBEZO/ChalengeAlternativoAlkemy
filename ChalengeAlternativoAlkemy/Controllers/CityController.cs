using ChalengeAlternativoAlkemy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChalengeAlternativoAlkemy.Controllers
{
    [ApiController]
    [Route("api/Cities")]
    public class CityController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CityController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<List<City>> Get()
        {
            return _context.Cities.ToList();
        }
    }
}
