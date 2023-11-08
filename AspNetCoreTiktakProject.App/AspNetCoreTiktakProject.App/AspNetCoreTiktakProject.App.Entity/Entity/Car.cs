using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Entity.Entity
{
    public class Car
    {
        public int Id { get; set; }
       
        public bool IsActive { get; set; }
        public string Location { get; set; }

        public virtual CarProperty CarProperty { get; set; }


    }
}
