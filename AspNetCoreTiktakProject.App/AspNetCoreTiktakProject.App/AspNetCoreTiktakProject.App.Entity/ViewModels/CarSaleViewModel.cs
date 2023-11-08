﻿using AspNetCoreTiktakProject.App.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Entity.ViewModels
{
    public class CarSaleViewModel
    {
        public int Id { get; set; }
        public DateTime StartedTime { get; set; }
        public string StartedPoint { get; set; }
        public int CustomerId { get; set; }  //foregn key
        public int CarId { get; set; }       //foregn key

        //public virtual Customer Customer { get; set; }  //navigation property
        public virtual Car Car { get; set; }
        public virtual List<Bill> Bills { get; set; }
    }
}
