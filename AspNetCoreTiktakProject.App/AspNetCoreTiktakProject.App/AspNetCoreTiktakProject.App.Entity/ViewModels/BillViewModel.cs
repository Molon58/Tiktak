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
        public string DestinationPoint { get; set; }

        public int CustomerId { get; set; } //foregn key
        public int CarSaleId { get; set; }  //foregn key





        [ForeignKey("CarSaleId")]
        [Required]
        public CarSale CarSale { get; set; }
    }
}
