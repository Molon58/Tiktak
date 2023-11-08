using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AspNetCoreTiktakProject.App.Entity.ViewModels
{
    public class ContactViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "İsim boş geçilemez")]
        [Display(Name = "Ad")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email boş geçilemez")]
        [EmailAddress(ErrorMessage = "Email formatı uygun değil")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Konu boş geçilemez")]
        [Display(Name = "Konu")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Mesaj boş geçilemez")]
        [Display(Name = "Mesaj")]
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
