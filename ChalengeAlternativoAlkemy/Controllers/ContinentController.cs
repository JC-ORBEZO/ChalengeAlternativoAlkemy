using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ChalengeAlternativoAlkemy.Controllers
{
    [ApiController]
    [Route("api/Continents")]
    public class ContinentController : ControllerBase
    {
        //Inyección de Contexto
        //P1
        private readonly ApplicationDbContext _context;
        //P2
        public ContinentController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Continents.ToList());
        }
    }
}
