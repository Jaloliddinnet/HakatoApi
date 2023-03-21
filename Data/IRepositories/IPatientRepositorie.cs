using HakatoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepositories
{
    public interface IPatientRepositorie
    {
        Task<IList<Patient>> GetAllAsync();
        Task<Patient> GetByIdAsync(int id);
        Task Add(Patient patient);
        Task Update(int Id ,Patient patient);
        Task DeleteByIdAsync(int id);
    }
}
