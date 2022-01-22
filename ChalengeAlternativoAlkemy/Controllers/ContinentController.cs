using ChalengeAlternativoAlkemy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<ActionResult<List<Continent>>> Get()
        {
            return await _context.Continents.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Continent continent)
        {
            _context.Continents.Add(continent);
            await _context.SaveChangesAsync();
            return Ok(_context.Continents.ToList());
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Continent continent,int id)
        {
            if (continent.Id != id) return BadRequest("El Id del continente no coincide con el Id de la URL");
            var existe = await _context.Continents.AnyAsync(x => x.Id == id);
            if (!existe) return NotFound();
            _context.Continents.Update(continent);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await _context.Continents.AnyAsync(x => x.Id == id);
            if (!existe) return NotFound();
            _context.Continents.Remove(new Continent { Id=id});
            await _context.SaveChangesAsync();
            return Ok();
        }
        
        
    }
}
