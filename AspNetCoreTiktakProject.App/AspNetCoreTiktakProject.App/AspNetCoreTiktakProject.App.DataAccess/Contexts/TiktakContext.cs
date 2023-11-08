using AspNetCoreTiktakProject.App.DataAccess.Identities;
using AspNetCoreTiktakProject.App.Entity.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.DataAccess.Contexts
{
    public class TiktakContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public TiktakContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarProperty> CarProperties { get; set; }
         public DbSet<CarSale> CarSales { get; set; }
        public DbSet<Bill> Bills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
            //modelBuilder.Entity<IdentityUserLogin<int>>()
            //    .HasKey(login => new { login.LoginProvider, login.ProviderKey });

            //modelBuilder.Entity<Bill>()
            // .HasOne(b => b.Customer)
            // .WithMany(c => c.Bills)
            // .HasForeignKey(b => b.CustomerId)
            // .OnDelete(DeleteBehavior.ClientCascade); // Cascade silmeyi engeller...

            //modelBuilder.Entity<Bill>().HasOne(b => b.Customer).WithMany(c => c.Bills).HasForeignKey(cs=>cs.CarSaleId).OnDelete(DeleteBehavior.ClientCascade);


            modelBuilder.Entity<Car>().HasData(
                new Car() { Id = 1,  IsActive = true, Location = "Beşiktaş" },
                new Car() { Id = 2,  IsActive = true, Location = "Beşiktaş" },
                new Car() { Id = 3,  IsActive = true, Location = "Beşiktaş" },
                new Car() { Id = 4,  IsActive = true, Location = "Beşiktaş" },
                new Car() { Id = 5,  IsActive = true, Location = "Beşiktaş" },
                new Car() { Id = 6, IsActive = true, Location = "Beşiktaş" },
                new Car() { Id = 7, IsActive = true, Location = "Beşiktaş" },

                new Car() { Id = 8,  IsActive = true, Location = "Kadıköy" },
                new Car() { Id = 9,  IsActive = true, Location = "Kadıköy" },
                new Car() { Id = 10, IsActive = true, Location = "Kadıköy" },
                new Car() { Id = 11, IsActive = true, Location = "Kadıköy" },
                new Car() { Id = 12, IsActive = true, Location = "Kadıköy" },
                new Car() { Id = 13, IsActive = true, Location = "Kadıköy" },
                new Car() { Id = 14, IsActive = true, Location = "Kadıköy" },

                new Car() { Id = 15, IsActive = true, Location = "Bakırköy" },
                new Car() { Id = 16, IsActive = true, Location = "Bakırköy" },
                new Car() { Id = 17, IsActive = true, Location = "Bakırköy" },
                new Car() { Id = 18, IsActive = true, Location = "Bakırköy" },
                new Car() { Id = 19, IsActive = true, Location = "Bakırköy" },

                new Car() { Id = 20,  IsActive = true, Location = "Bakırköy" },
                new Car() { Id = 21,  IsActive = true, Location = "Bakırköy" },

                new Car() { Id = 22, IsActive = true, Location = "Maltepe" },
                new Car() { Id = 23,  IsActive = true, Location = "Maltepe" },
                new Car() { Id = 24,  IsActive = true, Location = "Maltepe" },
                new Car() { Id = 25,  IsActive = true, Location = "Maltepe" },
                new Car() { Id = 26,  IsActive = true, Location = "Maltepe" },

                new Car() { Id = 27, IsActive = true, Location = "Maltepe" },
                new Car() { Id = 28, IsActive = true, Location = "Maltepe" }

            );

            modelBuilder.Entity<CarProperty>().HasData(
                //besiktas bölgesi araçlar
                new CarProperty() { Id = 1, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 5, MinutePrice = 5 },
                new CarProperty() { Id = 2, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 6, MinutePrice = 5 },
                new CarProperty() { Id = 3, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 7, MinutePrice = 5 },

                new CarProperty() { Id = 4, Brand = "Toyota Corolla", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 1, MinutePrice = 7 },
                new CarProperty() { Id = 5, Brand = "Toyota Corolla", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 2, MinutePrice = 7 },
                new CarProperty() { Id = 6, Brand = "Toyota Corolla", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 3, MinutePrice = 7, },
                new CarProperty() { Id = 7, Brand = "Toyota Corolla", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 4, MinutePrice = 7 },

                //kadıköy bölgesi araçlar
                new CarProperty() { Id = 8, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 12, MinutePrice = 5 },
                new CarProperty() { Id = 9, Brand = "Renault Clio", Model = "2023", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 13, MinutePrice = 5 },
                new CarProperty() { Id = 10, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 14, MinutePrice = 5 },

                new CarProperty() { Id = 11, Brand = "Toyota Corolla", Model = "2022", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 8, MinutePrice = 7 },
                new CarProperty() { Id = 12, Brand = "Toyota Corolla", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 9, MinutePrice = 7 },
                new CarProperty() { Id = 13, Brand = "Toyota Corolla", Model = "2022", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 10, MinutePrice = 7 },
                new CarProperty() { Id = 14, Brand = "Toyota Corolla", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 11, MinutePrice = 7 },

                //bakırköy bölgesi araçlar
                new CarProperty() { Id = 15, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 19, MinutePrice = 5 },
                new CarProperty() { Id = 16, Brand = "Renault Clio", Model = "2023", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 20, MinutePrice = 5 },
                new CarProperty() { Id = 17, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 21, MinutePrice = 5 },

                new CarProperty() { Id = 18, Brand = "Toyota Corolla", Model = "2022", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 15, MinutePrice = 7 },
                new CarProperty() { Id = 19, Brand = "Toyota Corolla", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 16, MinutePrice = 7 },
                new CarProperty() { Id = 20, Brand = "Toyota Corolla", Model = "2022", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 17, MinutePrice = 7 },
                new CarProperty() { Id = 21, Brand = "Toyota Corolla", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 18, MinutePrice = 7 },

                //maltepe bölgesi araçlar

                new CarProperty() { Id = 22, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 26, MinutePrice = 5 },
                new CarProperty() { Id = 23, Brand = "Renault Clio", Model = "2023", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 27, MinutePrice = 5 },
                new CarProperty() { Id = 24, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 28, MinutePrice = 5 },

                new CarProperty() { Id = 25, Brand = "Toyota Corolla", Model = "2022", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 22, MinutePrice = 7 },
                new CarProperty() { Id = 26, Brand = "Toyota Corolla", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 23, MinutePrice = 7 },
                new CarProperty() { Id = 27, Brand = "Toyota Corolla", Model = "2022", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 24, MinutePrice = 7 },
                new CarProperty() { Id = 28, Brand = "Toyota Corolla", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/images/resim", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", CarId = 25, MinutePrice = 7 }

                );

            //customer data
            

            //virtual poss data

        

         

            modelBuilder.Entity<CarSale>().HasData(
               new CarSale() { Id = 1, StartedTime = DateTime.Now,  StartedPoint = "Beşiktaş", CustomerId = 1, CarId = 3 },
               new CarSale() { Id = 2, StartedTime = DateTime.Now, StartedPoint = "Bakırköy",  CustomerId = 2, CarId = 11 },
               new CarSale() { Id = 3, StartedTime = DateTime.Now, StartedPoint = "Maltepe",  CustomerId = 3, CarId = 1 }


               );
            modelBuilder.Entity<Bill>().HasData(
                new Bill() { Id = 1, Price = 275, OccuredDate = DateTime.Now, CustomerId = 1, CarSaleId = 1, FinishedTime = DateTime.Now.AddHours(2), DestinationPoint = "Maltepe" },
                new Bill() { Id = 2, Price = 355, OccuredDate = DateTime.Now, CustomerId = 2, CarSaleId = 2, FinishedTime = DateTime.Now.AddHours(1),DestinationPoint = "Beşiktaş" },
                new Bill() { Id = 3, Price = 400, OccuredDate = DateTime.Now, CustomerId = 3, CarSaleId = 3, FinishedTime = DateTime.Now.AddHours(1), DestinationPoint = "Kadıköy", }
                );








        }

    }
    
}
