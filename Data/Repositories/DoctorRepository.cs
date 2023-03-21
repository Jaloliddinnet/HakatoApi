using Data.IRepositories;
using HakatoApi.DBContext;
using HakatoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        AppDbContext context;
        public DoctorRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task Delete(int id)
        {
            var doctr = await context.doctor.FirstOrDefaultAsync(p => p.Id == id);
            context.doctor.Remove(doctr);
            await context.SaveChangesAsync();
        }

        public async Task<List<Doctor>> GetAll()
        {
            var doctr = await context.doctor.ToListAsync();
            return doctr;
        }

        public async Task<Doctor> GetById(int id)
        {
            var doctr = await context.doctor.FirstOrDefaultAsync(p => p.Id == id);
            return doctr;
        }

        public async Task Update(int Id, Doctor doctor)
        {
            var OldDoctor = await context.doctor.FirstOrDefaultAsync(p => p.Id == Id);
            doctor.Id = Id;
            context.doctor.Attach(OldDoctor).CurrentValues
                .SetValues(doctor);
            await context.SaveChangesAsync();
        }

        public async Task Add(Doctor doctor)
        {
            context.doctor.AddAsync(doctor);
            await context.SaveChangesAsync();
        }
    }
}
