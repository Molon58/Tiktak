using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Entity.Entity
{
    public class Bill
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public DateTime OccuredDate { get; set; }
        public DateTime FinishedTime { get; set; }
        public string DestinationPoint { get; set; }

        public int CustomerId { get; set; } //foregn key
        public int CarSaleId { get; set; }  //foregn key
        public int VirtualPosId { get; set; } //foreıgn key
        public int CarPropertyId { get; set; }


        [ForeignKey("CarSaleId")]
        [Required]
        public virtual CarSale CarSale { get; set; }
        public virtual CarProperty CarProperty { get; set; }
    }
}
