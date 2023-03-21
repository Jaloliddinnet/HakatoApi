using HakatoApi.Models;

namespace Data.IRepositories
{
    public interface IDoctorRepository
    {
        Task Add(Doctor doctor);
        Task<List<Doctor>> GetAll();
        Task Delete(int id);
        Task Update(int Id, Doctor doctor);
        Task<Doctor> GetById(int id);

    }
}
