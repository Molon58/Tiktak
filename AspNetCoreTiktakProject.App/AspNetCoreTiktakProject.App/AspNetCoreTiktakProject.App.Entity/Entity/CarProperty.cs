using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Entity.Entity
{
    public class CarProperty
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string FuelType { get; set; }
        public string GearType { get; set; }
        public string ImageUrl { get; set; }
        public string? Plaque { get; set; }
        public int TotalPerson { get; set; }
        public string? Baggage { get; set; }
        public decimal MinutePrice { get; set; }

        public int CarId { get; set; } // foreign key

        public virtual Car Car { get; set; } //navigation 
    }
}
