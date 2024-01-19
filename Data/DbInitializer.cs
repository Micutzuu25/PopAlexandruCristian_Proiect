using Microsoft.EntityFrameworkCore;
using PopAlexandru_Proiect2.Models;
using PopAlexandruCristian_Proiect.Data;
using static NuGet.Packaging.PackagingConstants;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;

namespace PopAlexandru_Proiect2.Data
{
    public class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new
           DealershipContext(serviceProvider.GetRequiredService
            <DbContextOptions<DealershipContext>>()))
            {
                if (context.Cars.Any())
                {
                    return; // BD a fost creata anterior
                }

                context.Cars.AddRange(
               new Car
               {
                   Brand = "Skoda",
                   Producer = "Klaus Zellmer",
                   Price = Decimal.Parse("25")
               },


               new Car
               {
                   Brand = "BMW",
                   Producer = "Oliver Zipse",
                   Price = Decimal.Parse("50")
               },


               new Car
               {
                   Brand = "Renault",
                   Producer = "Luca de Meo",
                   Price = Decimal.Parse("30")
               },

                new Car
                {
                    Brand = "Seat",
                    Producer = "Wayne Griffiths",
                    Price = Decimal.Parse("60")
                },
                 new Car
                 {
                     Brand = "Volkswagen",
                     Producer = "Oliver Blume",
                     Price = Decimal.Parse("55")
                 },

                  new Car
                  {
                      Brand = "Toyota",
                      Producer = "Koji Sato",
                      Price = Decimal.Parse("20")
                  }


               );


                context.Customers.AddRange(
                new Customer
                {
                    Name = "Pop Alexandru",
                    Adress = "Str. Morii, nr. 7A",
                    BirthDate = DateTime.Parse("2002-03-25")
                },
                new Customer
                {
                    Name = "Pop Vasile",
                    Adress = "Str. Fabricii, nr.1,ap. 120",
                    BirthDate = DateTime.Parse("1975 - 05 - 28")
                }


                );

                context.SaveChanges();

                var orders = new Order[]

  {
 new Order{CarID = 1,CustomerID=1,OrderDate=DateTime.Parse("2021-02-25")},
 new Order{CarID = 3,CustomerID=1,OrderDate=DateTime.Parse("2021-11-28")},
 new Order{CarID = 6,CustomerID=1,OrderDate=DateTime.Parse("2021-12-28")},
 new Order{CarID = 2,CustomerID=2,OrderDate=DateTime.Parse("2021-09-28")},
 new Order{CarID = 7,CustomerID=2,OrderDate=DateTime.Parse("2021-06-28")},
 new Order{CarID = 8,CustomerID=2,OrderDate=DateTime.Parse("2021-10-28")},
 };
                foreach (Order e in orders)
                {
                    context.Orders.Add(e);
                }
                context.SaveChanges();
                var publishers = new Models.Publisher[]
                {

 new Models.Publisher{PublisherName="Test1",Adress="Starda Test1"},
 new Models.Publisher{PublisherName="Test2",Adress="Starda Test2"},
 new Models.Publisher{PublisherName="Test3",Adress="Starda Test3"},
                };
                foreach (Models.Publisher p in publishers)
                {
                    context.Publishers.Add(p);
                }
                context.SaveChanges();
                var cars = context.Cars;
                var publishedcars = new PublishedCar[]
                {
 new PublishedCar {CarID = cars.Single(c => c.Brand == "Skoda" ).ID,PublisherID = publishers.Single(i => i.PublisherName =="Test1").ID
 },
 new PublishedCar {CarID = cars.Single(c => c.Brand == "BMW" ).ID,PublisherID = publishers.Single(i => i.PublisherName =="Test2").ID
 },
 new PublishedCar {CarID = cars.Single(c => c.Brand == "Renault" ).ID,PublisherID = publishers.Single(i => i.PublisherName =="Test3").ID
 },
 new PublishedCar {CarID = cars.Single(c => c.Brand == "Seat" ).ID,PublisherID = publishers.Single(i => i.PublisherName == "Test2").ID
 },
 new PublishedCar {CarID = cars.Single(c => c.Brand == "Volkswagen" ).ID,PublisherID = publishers.Single(i => i.PublisherName == "Test1").ID
 },
 new PublishedCar {CarID = cars.Single(c => c.Brand == "Toyota" ).ID,PublisherID = publishers.Single(i => i.PublisherName == "Test3").ID
 },
                };
                foreach (PublishedCar pb in publishedcars)
                {
                    context.PublishedCars.Add(pb);
                }
                context.SaveChanges();
            }
        }
    }
}

