using AspNetCoreTiktakProject.App.Entity.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Entity.ViewModels
{
    public class BillViewModel
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public DateTime OccuredDate { get; set; }
        public DateTime FinishedTime { get; set; }
        [Required(ErrorMessage = "Lütfen aracı bıraktığınız noktayı yazınız.")]
        public string DestinationPoint { get; set; }

        public int CustomerId { get; set; } //foregn key
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string CardFullName { get; set; }
        public string CardNumber { get; set; }
        public string CvvNumber { get; set; }
        public string ExpireDate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string FuelType { get; set; }
        public string GearType { get; set; }
        public string Plaque { get; set; }
        public int TotalPerson { get; set; }
        public string Baggage { get; set; }
        public int CarSaleId { get; set; }  //foregn key
        public int CarPropertyId { get; set; }
        public List<Bill> Bills { get; set; }


        public virtual CarProperty CarProperty { get; set; }


        [ForeignKey("CarSaleId")]
        [Required]
        public CarSale CarSale { get; set; }
    }
}
