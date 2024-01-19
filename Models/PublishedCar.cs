namespace PopAlexandru_Proiect2.Models
{
    public class PublishedCar
    {
        public int PublisherID { get; set; }
        public int CarID { get; set; }
        public Publisher Publisher { get; set; }
        public Car Car { get; set; }
    }
}
