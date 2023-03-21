using AutoMapper;
using HakatoApi.DBContext;
using HakatoApi.DTO.sickness;
using HakatoApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using servise.Servises;

namespace HakatoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SicknessController : ControllerBase
    {
        //private readonly ISicknessServise _servise;

        //public SicknessController(ISicknessServise servise)
        //{
        //    _servise = servise;
        //}

        //[HttpGet("Get")]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok(context.sickness.Include(p => p.doctors ).Include(p => p.patient).ToList());
        //}
        //[HttpPost("Add")]
        //public async Task<IActionResult> Addsicness( AddsicknessDTO addsicknessdto)
        //{
        //    var sickness = mapper.Map<sickness>(addsicknessdto);


        //    await context.sickness.AddAsync(sickness);
        //    await context.SaveChangesAsync();

        //    return Ok(context.sickness);
        //}

        //[HttpPut("Updata")]

        //public async Task<IActionResult> Updatadoctor(int id, AddsicknessDTO addsicknessDTO)
        //{
        //    var Oldsickness = await context.sickness.FirstOrDefaultAsync(p => p.ID == id);
        //    var newsickness = mapper.Map<sickness>(addsicknessDTO);
        //    newsickness.ID = id;

        //    context.sickness.Attach(Oldsickness).CurrentValues.SetValues(newsickness);
        //    await context.SaveChangesAsync();


        //    await context.SaveChangesAsync();
        //    return Ok(context.sickness);
        //}
    }
}

