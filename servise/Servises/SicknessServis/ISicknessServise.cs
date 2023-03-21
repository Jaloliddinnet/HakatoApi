using HakatoApi.DTO.sickness;
using HakatoApi.Models;

namespace servise.Servises
{
    public interface ISicknessServise
    {
        Task AddAsync(AddsicknessDTO addsicknessDTO);
        Task UpdateAsync(int Id, AddsicknessDTO addsicknessDTO);
        Task DeleteAsync(int Id);
        Task<IList<sickness>> GetAllAsync();
        Task<sickness>  GetById(int Id);
    }
}
