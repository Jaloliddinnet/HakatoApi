namespace HakatoApi.DTO.sickness
{
    public class AddsicknessDTO
    {
        public string sickness_name { get; set; }
        public DateTime inTheHospital { get; set; }
        public DateTime outTheHospital { get; set; }
        public string info { get; set; }
        public int patient_id { get; set; }
    }
}
