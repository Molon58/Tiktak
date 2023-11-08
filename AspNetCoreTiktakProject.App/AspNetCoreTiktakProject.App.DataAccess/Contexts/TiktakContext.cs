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

        public DbSet<CarProperty> CarProperties { get; set; }
        public DbSet<CarSale> CarSales { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Contact> Contacts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //modelBuilder.Entity<IdentityUserLogin<int>>()
            //    .HasKey(login => new { login.LoginProvider, login.ProviderKey });

        //    modelBuilder.Entity<Bill>().
        // HasRequired(b => b.CarSale)
        //.WithMany(cs => cs.Bills)
        //.HasForeignKey(b => b.CarSaleId)
        //.WillCascadeOnDelete(false);

            modelBuilder.Entity<Bill>()
             .HasOne(b => b.CarSale)
             .WithMany(c => c.Bills)
             .HasForeignKey(b => b.CarSaleId)
             .OnDelete(DeleteBehavior.ClientCascade); // Cascade silmeyi engeller...

            //modelBuilder.Entity<Bill>().HasOne(b => b.Customer).WithMany(c => c.Bills).HasForeignKey(cs=>cs.CarSaleId).OnDelete(DeleteBehavior.ClientCascade);




            modelBuilder.Entity<CarProperty>().HasData(
            //besiktas bölgesi araçlar
            new CarProperty() { Id = 1, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Kadıköy", IsActive = true },
            new CarProperty() { Id = 2, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Kadıköy", IsActive = true },
            new CarProperty() { Id = 3, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Kadıköy", IsActive = true },

            new CarProperty() { Id = 4, Brand = "Mini Cooper", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/miniana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/minidetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/minidetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/minidetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/minidetay4.jpeg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 15, Location = "Kadıköy", IsActive = true },
            new CarProperty() { Id = 5, Brand = "Mini Cooper", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/miniana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/minidetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/minidetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/minidetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/minidetay4.jpeg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 15, Location = "Kadıköy", IsActive = true },
            new CarProperty() { Id = 7, Brand = "Mini Cooper", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/miniana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/minidetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/minidetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/minidetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/minidetay4.jpeg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 15, Location = "Kadıköy", IsActive = true },

            //kadıköy bölgesi araçlar
            new CarProperty() { Id = 8, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Beşiktaş", IsActive = true },
            new CarProperty() { Id = 9, Brand = "Renault Clio", Model = "2023", FuelType = "Benzin", GearType = "Manuel", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Beşiktaş", IsActive = true },
            new CarProperty() { Id = 10, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Manuel", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Beşiktaş", IsActive = true },

            new CarProperty() { Id = 11, Brand = "Mini Cooper", Model = "2022", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/miniana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/minidetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/minidetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/minidetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/minidetay4.jpeg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 15, Location = "Beşiktaş", IsActive = true },
            new CarProperty() { Id = 12, Brand = "Mini Cooper", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/miniana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/minidetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/minidetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/minidetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/minidetay4.jpeg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 15, Location = "Beşiktaş", IsActive = true },
            new CarProperty() { Id = 13, Brand = "Mini Cooper", Model = "2022", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/miniana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/minidetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/minidetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/minidetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/minidetay4.jpeg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 15, Location = "Beşiktaş", IsActive = true },
            new CarProperty() { Id = 14, Brand = "Mini Cooper", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/miniana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/minidetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/minidetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/minidetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/minidetay4.jpeg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 15, Location = "Beşiktaş", IsActive = true },

            //bakırköy bölgesi araçlar
            new CarProperty() { Id = 15, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Maltepe", IsActive = true },
            new CarProperty() { Id = 16, Brand = "Renault Clio", Model = "2023", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Maltepe", IsActive = true },
            new CarProperty() { Id = 17, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Maltepe", IsActive = true },

            new CarProperty() { Id = 18, Brand = "Renault Clio", Model = "2022", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Maltepe", IsActive = true },
            new CarProperty() { Id = 19, Brand = "Renault Clio", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Maltepe", IsActive = true },
            new CarProperty() { Id = 20, Brand = "Renault Clio", Model = "2022", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Maltepe", IsActive = true },
            new CarProperty() { Id = 21, Brand = "Renault Clio", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Maltepe", IsActive = true },

            //maltepe bölgesi araçlar

            new CarProperty() { Id = 22, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Bakırköy", IsActive = true },
            new CarProperty() { Id = 23, Brand = "Renault Clio", Model = "2023", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Bakırköy", IsActive = true },
            new CarProperty() { Id = 24, Brand = "Renault Clio", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Bakırköy", IsActive = true },

            new CarProperty() { Id = 25, Brand = "Renault Clio", Model = "2022", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Bakırköy", IsActive = true },
            new CarProperty() { Id = 26, Brand = "Renault Clio", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Bakırköy", IsActive = true },
            new CarProperty() { Id = 27, Brand = "Renault Clio", Model = "2022", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Bakırköy", IsActive = true },
            new CarProperty() { Id = 28, Brand = "Renault Clio", Model = "2022", FuelType = "Benzin", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/renoana.jpg", ImageDetailUrl1 = "/Templete/car-rental-html-template/img/renodetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/renodetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/renodetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/renodetay4.jpg", Plaque = "34KYN321", TotalPerson = 4, Baggage = "Station", MinutePrice = 10, Location = "Bakırköy", IsActive = true },

            //yeni data 11.10.2023
             new CarProperty() { Id = 30, Brand = "Volkswagen Golf", Model = "2022", FuelType = "Elektrik", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/vwgolfana.jpg", Plaque = "34AA300", TotalPerson = 4, Baggage = "Station", MinutePrice = 15, Location = "Maltepe", IsActive = true,ImageDetailUrl1= "/Templete/car-rental-html-template/img/vwgolfdetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/vwgolfdetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/vwgolfdetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/vwgolfdetay4.jpg" },

             new CarProperty() { Id = 31, Brand = "Volkswagen Passat", Model = "2023", FuelType = "Elektrik", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/vwpassatana.jpg", Plaque = "34BB311", TotalPerson = 4, Baggage = "Station", MinutePrice = 15, Location = "Maltepe", IsActive = true, ImageDetailUrl1 = "/Templete/car-rental-html-template/img/vwpassatdetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/vwpassatdetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/vwpassatdetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/vwpassatdetay4.jpg" },

             new CarProperty() { Id = 32, Brand = "Mercedes Amg", Model = "2023", FuelType = "Benzinli", GearType = "Manuel", ImageUrl = "/Templete/car-rental-html-template/img/mercedes1ana.jpg", Plaque = "34BB311", TotalPerson = 4, Baggage = "Station", MinutePrice = 25, Location = "Bakırköy", IsActive = true, ImageDetailUrl1 = "/Templete/car-rental-html-template/img/mercedes1detay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/mercedes1detay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/mercedes1detay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/mercedes1detay4.jpg" },

             new CarProperty() { Id = 33, Brand = "Mercedes Amg", Model = "2023", FuelType = "Benzinli", GearType = "Manuel", ImageUrl = "/Templete/car-rental-html-template/img/mercedes1ana.jpg", Plaque = "34BB311", TotalPerson = 4, Baggage = "Station", MinutePrice = 25, Location = "Bakırköy", IsActive = true, ImageDetailUrl1 = "/Templete/car-rental-html-template/img/mercedes1detay1.jpeg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/mercedes1detay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/mercedes1detay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/mercedes1detay4.jpg" },

             new CarProperty() { Id = 34, Brand = "Mercedes G63", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/g63siyahana.jpg", Plaque = "34BB311", TotalPerson = 4, Baggage = "Station", MinutePrice = 25, Location = "Kadıköy", IsActive = true, ImageDetailUrl1 = "/Templete/car-rental-html-template/img/g63siyahdetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/g63siyahdetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/g63siyahdetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/g63siyahdetay4.jpg" },

             new CarProperty() { Id = 35, Brand = "Mercedes G63", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/g63siyahana.jpg", Plaque = "34BB311", TotalPerson = 4, Baggage = "Station", MinutePrice = 25, Location = "Kadıköy", IsActive = true, ImageDetailUrl1 = "/Templete/car-rental-html-template/img/g63siyahdetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/g63siyahdetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/g63siyahdetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/g63siyahdetay4.jpg" },

              new CarProperty() { Id = 36, Brand = "Fiat Egea", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/egeaana.jpg", Plaque = "34BB311", TotalPerson = 4, Baggage = "Station", MinutePrice = 13, Location = "Kadıköy", IsActive = true, ImageDetailUrl1 = "/Templete/car-rental-html-template/img/egeadetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/egeadetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/egeadetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/egeadetay4.jpg" },
              new CarProperty() { Id = 37, Brand = "Fiat Egea", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/egeaana.jpg", Plaque = "34BB311", TotalPerson = 4, Baggage = "Station", MinutePrice = 13, Location = "Kadıköy", IsActive = true, ImageDetailUrl1 = "/Templete/car-rental-html-template/img/egeadetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/egeadetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/egeadetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/egeadetay4.jpg" },

               new CarProperty() { Id = 38, Brand = "Fiat Egea", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/egeaana.jpg", Plaque = "34BB311", TotalPerson = 4, Baggage = "Station", MinutePrice = 13, Location = "Kadıköy", IsActive = true, ImageDetailUrl1 = "/Templete/car-rental-html-template/img/egeadetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/egeadetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/egeadetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/egeadetay4.jpg" },

                new CarProperty() { Id = 39, Brand = "Fiat Egea", Model = "2023", FuelType = "Dizel", GearType = "Otomatik", ImageUrl = "/Templete/car-rental-html-template/img/egeaana.jpg", Plaque = "34BB311", TotalPerson = 4, Baggage = "Station", MinutePrice = 13, Location = "Kadıköy", IsActive = true, ImageDetailUrl1 = "/Templete/car-rental-html-template/img/egeadetay1.jpg", ImageDetailUrl2 = "/Templete/car-rental-html-template/img/egeadetay2.jpg", ImageDetailUrl3 = "/Templete/car-rental-html-template/img/egeadetay3.jpg", ImageDetailUrl4 = "/Templete/car-rental-html-template/img/egeadetay4.jpg" }






            );

            





            modelBuilder.Entity<CarSale>().HasData(
                           new CarSale() { Id = 1, StartedTime = DateTime.Now, StartedPoint = "Beşiktaş", CustomerId = 1, CarPropertyId = 1 },
                           new CarSale() { Id = 2, StartedTime = DateTime.Now, StartedPoint = "Bakırköy", CustomerId = 2, CarPropertyId = 2 },
                           new CarSale() { Id = 3, StartedTime = DateTime.Now, StartedPoint = "Maltepe", CustomerId = 3, CarPropertyId = 3 }


                           );
            modelBuilder.Entity<Bill>().HasData(
                new Bill() { Id = 1, Price = 275, OccuredDate = DateTime.Now, CustomerId = 1, CarSaleId = 1, FinishedTime = DateTime.Now.AddHours(2), DestinationPoint = "Maltepe",CarPropertyId = 2 },
                new Bill() { Id = 2, Price = 355, OccuredDate = DateTime.Now, CustomerId = 2, CarSaleId = 2, FinishedTime = DateTime.Now.AddHours(1), DestinationPoint = "Beşiktaş",CarPropertyId=2},
                new Bill() { Id = 3, Price = 400, OccuredDate = DateTime.Now, CustomerId = 3, CarSaleId = 3, FinishedTime = DateTime.Now.AddHours(1), DestinationPoint = "Kadıköy",CarPropertyId=2 }
                );








        }

    }

}
