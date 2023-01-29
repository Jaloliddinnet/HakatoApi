using HakatoApi.DBContext;
using HakatoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HakatoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SicknessController : ControllerBase
    {
        AppDbContext context;
        public SicknessController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddDoctor(sickness sickness)
        {
            await context.sickness.AddAsync(sickness);
            await context.SaveChangesAsync();

            return Ok(context.sickness);
        }

    }
}

