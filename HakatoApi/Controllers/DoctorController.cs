using HakatoApi.DBContext;
using HakatoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HakatoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        AppDbContext context;
        public DoctorController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(context.doctor.ToList());
        }

        [HttpPost("Add Doctor")]
        public async Task<IActionResult> AddDoctor(Doctor doctor)
        {
            await context.doctor.AddAsync(doctor);
            await context.SaveChangesAsync();

            return Ok(context.doctor);
        }

        [HttpPut("Updata")]

        public async Task<IActionResult> Updatadoctor(int id,Doctor doctor)
        {
            var OldDoctor = await context.doctor.FirstOrDefaultAsync(p => p.Id == id);

        if (OldDoctor == null)
          return NotFound("Parint is not found");

            OldDoctor.First_name = doctor.First_name;
            OldDoctor.Last_name = doctor.Last_name;
            OldDoctor.Worklocation = doctor.Worklocation;
            OldDoctor.Direction= doctor.Direction;

            await context.SaveChangesAsync();
            return Ok(context.patient);
        }


    }
}
