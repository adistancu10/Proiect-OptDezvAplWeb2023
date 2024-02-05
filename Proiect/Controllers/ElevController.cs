using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect.Data;
using Proiect.Models;
using Microsoft.EntityFrameworkCore;


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



    }
}
