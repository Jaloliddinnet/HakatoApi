using Microsoft.VisualBasic;

namespace HakatoApi.Models
{
    public class sickness
    {
        public int ID { get; set; }
        public string sickness_name { get; set; }
        public DateTime inTheHospital { get; set; }
        public DateTime outTheHospital { get; set;}
        public string info { get; set; }
        public int doctor_id { get; set; }
    }
}
