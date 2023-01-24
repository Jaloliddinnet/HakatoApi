namespace HakatoApi.Models
{
    public class Patient
    {
        public int ID { get; set; }
        public string Last_name { get; set; }
        public string First_name { get; set; }
        public string HomeLocation { get; set; }
        public string Direction { get; set; }//Qo'shimcha malumotlar nechi 
        public bool patient { get; set; }
        public bool gender { get; set; }
    }
}
