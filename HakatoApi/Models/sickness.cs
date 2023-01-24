using Microsoft.VisualBasic;

namespace HakatoApi.Models
{
    public class sickness
    {
        public int ID { get; set; }
        public string sickness_name { get; set; }
        public TimeSpan inTheHospital { get; set; }
        public TimeSpan outTheHospital { get; set;}
        public string info { get; set; }
        public int doctor_id { get; set; }
    }
}
