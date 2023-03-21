using HakatoApi.DTO.Doctor;
using HakatoApi.Models;
using servise.DTO.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servise.Servises.DoctorSer
{
    public interface IDoctorServis
    {
        Task Add(AddDoctorDTO addDoctorDTO);
        Task update(int id , AddDoctorDTO addDoctorDTO);
        Task<List<Doctor>> GetAll();
        Task Delete(int id);
        Task<Doctor> GetById(int id);
    }
}
