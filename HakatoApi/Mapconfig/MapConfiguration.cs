using AutoMapper;
using HakatoApi.DTO.Doctor;
using HakatoApi.DTO.Patients;
using HakatoApi.DTO.sickness;
using HakatoApi.Models;
using servise.DTO.Doctor;

namespace HakatoApi.Mapconfig
{
    public class MapConfiguration : Profile
    {
        public MapConfiguration() 
        {
            CreateMap<Doctor ,AddDoctorDTO>().ReverseMap();
            CreateMap<Doctor , PrintDoctorDto>().ReverseMap();
            CreateMap<Patient, AddPatientsDTO>().ReverseMap();
            CreateMap<sickness, AddsicknessDTO>().ReverseMap();
        }       
    }
}
