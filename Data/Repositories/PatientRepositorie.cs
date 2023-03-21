using Data.IRepositories;
using HakatoApi.DBContext;
using HakatoApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class PatientRepositorie : IPatientRepositorie
    {
        private readonly AppDbContext _appDbContext;
        public PatientRepositorie(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task Add(Patient patient)
        {
            _appDbContext.patient.AddAsync(patient);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteByIdAsync(int id)
        {
          var DelPatient = await _appDbContext.patient.FirstOrDefaultAsync(p => p.ID== id);
            if (DelPatient != null)
            {
                _appDbContext.patient.Remove(DelPatient);
                await _appDbContext.SaveChangesAsync();
            }
        }

        public async Task<IList<Patient>> GetAllAsync()
        {
           return await _appDbContext.patient.ToListAsync();
        }

        public async Task<Patient> GetByIdAsync(int id)
        {
            return await _appDbContext.patient.FirstOrDefaultAsync(p => p.ID == id);
        }

        public async Task Update(int Id, Patient patient)
        {
            var OldPatient = await _appDbContext.patient.FirstOrDefaultAsync(p => p.ID == Id);
            patient.ID = Id;
            _appDbContext.patient.Attach(OldPatient).CurrentValues
                .SetValues(patient);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
