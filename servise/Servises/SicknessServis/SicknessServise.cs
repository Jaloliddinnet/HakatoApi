using AutoMapper;
using Data.IRepositories;
using HakatoApi.DTO.sickness;
using HakatoApi.Models;

namespace servise.Servises.SicknessServis
{
    public class SicknessServise : ISicknessServise
    {
        private readonly ISicknessRepositorie _sickness;
        private readonly IMapper _mapper;
        public SicknessServise(ISicknessRepositorie sickness, IMapper mapper)
        {
            _sickness = sickness;
            _mapper = mapper;
        }

        public async Task AddAsync(AddsicknessDTO addsicknessDTO)
        {
            await _sickness.AddAsync(_mapper.Map<sickness>(addsicknessDTO));
        }

        public async Task DeleteAsync(int Id)
        {
            await _sickness.DeleteAsync(Id);
        }

        public async Task<IList<sickness>> GetAllAsync()
        {
          return await _sickness.GetAllAsync();
        }

        public async Task<sickness> GetById(int Id)
        {
            return await _sickness.GetById(Id);
        }

        public async Task UpdateAsync(int Id, AddsicknessDTO addsicknessDTO)
        {
           await _sickness.UpdateAsync(Id, _mapper.Map<sickness>(addsicknessDTO));
        }
    }
}
