﻿namespace HakatoApi.DTO.Doctor
{
    public class AddDoctorDTO
    {
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public int price { get; set; }// Qobilyatini baholash
        public string Worklocation { get; set; }
        public string Direction { get; set; }// Qo'shimcha malumotlar
    }
}