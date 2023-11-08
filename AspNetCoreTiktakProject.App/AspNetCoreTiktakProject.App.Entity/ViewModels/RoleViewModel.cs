using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Entity.ViewModels
{
    public class RoleViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Rol adı boş geçilemez")]
        [Display(Name = "Rol Adı")]
        public string Name { get; set; }
    }
}
