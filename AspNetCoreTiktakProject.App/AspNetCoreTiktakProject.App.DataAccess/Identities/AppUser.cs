using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.DataAccess.Identities
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string DriverLicence { get; set; }
        public string CardNumber { get; set; }
        public string CardFullName { get; set; }
        public string ExpireDate { get; set; }
        public string CvvNumber { get; set; }
        public bool IsOnDrive { get; set; } = false;




    }
}
