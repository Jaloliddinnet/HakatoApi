using HakatoApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.IRepositories
{
    public interface ISicknessRepositorie
    {
        Task AddAsync(sickness sickness);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id,sickness sickness);
        Task<sickness> GetById(int id);
        Task<IList<sickness>> GetAllAsync();
    }
}
