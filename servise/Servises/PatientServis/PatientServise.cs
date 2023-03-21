using AutoMapper;
using Data.IRepositories;
using HakatoApi.DTO.Patients;
using HakatoApi.Models;

namespace servise.Servises
{
    public class PatientServise : IPatientServise
    {
        private readonly IPatientRepositorie _repositorie;
        private readonly IMapper _mapper;
        public PatientServise(IPatientRepositorie repositorie, IMapper mapper)
        {
            _repositorie = repositorie;
            _mapper = mapper;
        }

        public async Task Add(AddPatientsDTO addPatientsDTO)
        {
           var patient =  _mapper.Map<Patient>(addPatientsDTO);
            patient.born = DateTime.Now;
           await _repositorie.Add(patient);
        }

        public async Task Delete(int Id)
        {
            await _repositorie.DeleteByIdAsync(Id); 
        }

        public async Task<IList<Patient>> GetAll()
        {
            return await _repositorie.GetAllAsync();
        }

        public async Task<Patient> GetById(int Id)
        {
           return  await _repositorie.GetByIdAsync(Id);
        }

        public async Task Update(int Id, AddPatientsDTO addPatientsDTO)
        {
            await _repositorie.Update(Id,_mapper.Map<Patient>(addPatientsDTO));
        }
    }
}
