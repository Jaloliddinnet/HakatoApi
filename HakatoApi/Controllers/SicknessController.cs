using HakatoApi.DBContext;
using HakatoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpPut("Updata")]

        public async Task<IActionResult> Updatadoctor(int id, sickness sickness)
        {
            var Oldsicness = await context.sickness.FirstOrDefaultAsync(p => p.ID == id);

            if (Oldsicness == null)
                return NotFound("Parint is not found");

            Oldsicness.doctor_id = Oldsicness.doctor_id;
            Oldsicness.sickness_name = sickness.sickness_name;
            Oldsicness.outTheHospital = sickness.outTheHospital;
            Oldsicness.inTheHospital = sickness.inTheHospital;
            Oldsicness.info = sickness.info;

            await context.SaveChangesAsync();
            return Ok(context.patient);
        }
    }
}

