using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Entity.Entity
{
    public class CarSale
    {
        public int Id { get; set; }
        public DateTime StartedTime { get; set; }
        public string StartedPoint { get; set; }
        public int CustomerId { get; set; }  //foregn key
        public int CarId { get; set; }       //foregn key

       
        public virtual Car Car { get; set; }
        public virtual List<Bill> Bills { get; set; }
    }
}
