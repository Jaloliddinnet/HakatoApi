using AutoMapper;
using Data.IRepositories;
using HakatoApi.DBContext;
using HakatoApi.DTO.Doctor;
using HakatoApi.Models;
using Microsoft.EntityFrameworkCore;
using servise.DTO.Doctor;
using System.Numerics;

namespace servise.Servises.DoctorSer
{
    public class DoctorServis : IDoctorServis
    {
        IDoctorRepository _repository;
        IMapper _mapper;
        public DoctorServis(IMapper mapper, IDoctorRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
         
        public async Task Add(AddDoctorDTO addDoctorDTO)
        {
           await _repository.Add( _mapper.Map<Doctor>(addDoctorDTO));
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }

        public async Task<List<Doctor>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Doctor> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task update(int id, AddDoctorDTO addDoctorDTO)
        {
           await _repository.Update(id,_mapper.Map<Doctor>(addDoctorDTO));
        }

        
    }
}
