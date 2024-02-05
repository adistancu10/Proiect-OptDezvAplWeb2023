using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect.Data;
using Proiect.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElevController : ControllerBase
    {
        private readonly tableContext _dbContext;

        public ElevController(tableContext dbContext)
        {
            _dbContext = dbContext;
        }

        //get

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var elevi = await _dbContext.Elevi.ToListAsync();
            return Ok(elevi);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(Guid id)
        {
            var elev = await _dbContext.Elevi.FirstOrDefaultAsync(el => el.Id == id);
            if (elev == null)
            {
                return NotFound();
            }

            return Ok(elev);
        }

        [HttpGet("filter/{name}/{cnp}")]
        public async Task<IActionResult> GetWithFilter(string name, string cnp)
        {
            var elev = await _dbContext.Elevi.FirstOrDefaultAsync(el => el.Nume.Equals(name) && el.CNP == cnp);
            if(elev == null)
            {
                return NotFound();
            }

            return Ok(elev);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Elev elevi)
        {
            _dbContext.Elevi.Add(elevi);
            await _dbContext.SaveChangesAsync();
            return Ok(elevi);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var elev = await _dbContext.Elevi.FirstOrDefaultAsync(el => el.Id == id);
            
            if (elev == null)
            {
                return NotFound();
            }
            _dbContext.Elevi.Remove(elev);
            await _dbContext.SaveChangesAsync();

            return Ok(elev);
        }

    }
}
