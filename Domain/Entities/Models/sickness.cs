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
        public int patient_id { get; set; }
        public   virtual Patient patient { get; set; }
        public virtual List<Doctor> doctors { get; set; }

        public sickness()
        {
            doctors= new List<Doctor>();
        }

    }
}
