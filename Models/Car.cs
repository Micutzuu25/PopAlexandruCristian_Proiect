using System.ComponentModel.DataAnnotations.Schema;

namespace PopAlexandru_Proiect2.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Producer { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<PublishedCar> PublishedCars { get; set; }

    }
}
