using Data.IRepositories;
using HakatoApi.DBContext;
using HakatoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class SicknessRepositorie : ISicknessRepositorie
    {
        private readonly AppDbContext _appDbContext;

        public SicknessRepositorie(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddAsync(sickness sickness)
        {
            _appDbContext.sickness.AddAsync(sickness);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var DelSickness = await _appDbContext.sickness.FirstOrDefaultAsync(p => p.ID == id);
            if (DelSickness != null)
            {
                _appDbContext.sickness.Remove(DelSickness);
                await _appDbContext.SaveChangesAsync();
            }
        }

        public async Task<IList<sickness>> GetAllAsync()
        {
            return await _appDbContext.sickness.ToListAsync();
        }

        public async Task<sickness> GetById(int id)
        {
           return await _appDbContext.sickness.FirstOrDefaultAsync(sickness => sickness.ID == id);
        }

        public async Task UpdateAsync(int id, sickness sickness)
        {
            var OldSickness = await _appDbContext.sickness.FirstOrDefaultAsync(p => p.ID == id);
            sickness.ID = id;
            _appDbContext.sickness.Attach(OldSickness).CurrentValues
                .SetValues(sickness);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
