using HakatoApi.DTO.Patients;
using HakatoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace servise.Servises
{
    public interface IPatientServise
    {
        Task Add(AddPatientsDTO addPatientsDTO);
        Task Update(int Id, AddPatientsDTO addPatientsDTO);
        Task Delete(int Id);
        Task<IList<Patient>> GetAll();
        Task<Patient> GetById(int Id);
    }
}
