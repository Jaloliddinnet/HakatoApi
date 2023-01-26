using HakatoApi.DBContext;
using HakatoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HakatoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        AppDbContext context;
        public PatientController(AppDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(context.patient.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> AddPatient(Patient patient)
        {
            await context.patient.AddAsync(patient);
            await context.SaveChangesAsync();

            return Ok(context.patient);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id,Patient patient)
        {
            var OldPatient = await context.patient.FirstOrDefaultAsync(p => p.ID == id);

            if (OldPatient == null)
                return NotFound("Parint is not found");

            OldPatient.Last_name = patient.Last_name;
            OldPatient.First_name= patient.First_name;
            OldPatient.HomeLocation= patient.HomeLocation;
            OldPatient.Direction= patient.Direction;
            OldPatient.patient = patient.patient;
            OldPatient.born =   patient.born;

            await context.SaveChangesAsync();
            return Ok(context.patient);
        }

        [HttpGet("Search")]
        public async Task<IActionResult> Search(string? SearchStringFirstName)
        {
             List<Patient> list = new List<Patient>();

            list = context.patient.Where(p => SearchStringFirstName == null || p.First_name.ToLower().Contains(SearchStringFirstName)).
                
                ToList();

            return Ok(list);
        }
    }
}
