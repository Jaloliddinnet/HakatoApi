using AutoMapper;
using HakatoApi.DBContext;
using HakatoApi.DTO.Doctor;
using HakatoApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using servise.Servises.DoctorSer;

namespace HakatoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
       private readonly IDoctorServis servis;
        public DoctorController(IDoctorServis servis)
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
        public async Task<IActionResult> AddDoctor([FromForm] AddDoctorDTO AddDoctor)
        {
            await servis.Add(AddDoctor);
            return Ok("Add");
        }

        [HttpPut("Updata")]
        public async Task<IActionResult> Updatadoctor(int id,[FromForm]AddDoctorDTO doctor)
        {
            await servis.update(id, doctor);
           return Ok("Updated");
        }
        [HttpDelete]
        public async Task<IActionResult> Deleted(int id)
        {
            await servis.Delete(id);
            return Ok("Deleted");
        }


        //[HttpGet("Search")]

        //public async Task<IActionResult> Search(string? searchstringFirsName , string? searchStringLastName)
        //{
        //    List<Doctor> list = new List<Doctor>();

        //    list = context.doctor.Where(p => searchstringFirsName == null || p.First_name.ToLower().Contains(searchstringFirsName)).
        //        Where(p => searchStringLastName == null || p.Last_name.ToLower().Contains(searchStringLastName)).ToList();

        //    return Ok(list);
        //}
    }

}

