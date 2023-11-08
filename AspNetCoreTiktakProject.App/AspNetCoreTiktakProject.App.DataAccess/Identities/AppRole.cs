using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.DataAccess.Identities
{
    public class AppRole :IdentityRole<int>
    {
        public DateTime CreatedTime { get; set; }
    }
}
