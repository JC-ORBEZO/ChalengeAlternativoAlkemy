using ChalengeAlternativoAlkemy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChalengeAlternativoAlkemy.Controllers
{
    [ApiController]
    [Route("api/Icons")]
    public class IconController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public IconController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Icon>>> Get()
        {
            //return await _context.Icons.ToListAsync();
            return await _context.Icons.ToListAsync();
        }
        /*
        [HttpPost]
        public async Task<ActionResult> Post(Icon icon)
        {
            _context.Icons.Add(icon);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Icon icon,int id)
        {
            var existe = await _context.Icons.AnyAsync(x => x.Id == id);
            if (!existe) return NotFound();
            _context.Icons.Update(icon);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await _context.Icons.AnyAsync(x => x.Id == id);
            if (!existe) return NotFound();
            _context.Icons.Remove(new Icon { Id = id });
            return Ok();
        }*/
    }
}
