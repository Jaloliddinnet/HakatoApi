using HakatoApi.DTO.Doctor;
using HakatoApi.DTO.Patients;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using servise.Servises;
using servise.Servises.DoctorSer;

namespace HakatoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientServise servis;

        public PatientController(IPatientServise servis)
        {
            this.servis = servis;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await servis.GetAll());
        }
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await servis.GetById(id));
        }
        [HttpPost]
        public async Task<IActionResult> AddDoctor([FromForm] AddPatientsDTO addPatients)
        {
            await servis.Add(addPatients);
            return Ok("Add");
        }

        [HttpPut("Updata")]
        public async Task<IActionResult> Updatadoctor(int id, [FromForm] AddPatientsDTO patent)
        {
            await servis.Update(id, patent);
            return Ok("Updated");
        }
        [HttpDelete]
        public async Task<IActionResult> Deleted(int id)
        {
            await servis.Delete(id);
            return Ok("Deleted");
        }
    }
}
