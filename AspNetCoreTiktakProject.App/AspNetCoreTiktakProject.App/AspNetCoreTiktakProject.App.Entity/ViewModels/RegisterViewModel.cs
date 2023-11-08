using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Entity.ViewModels
{
    public class RegisterViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "İsim alanı boş geçilemez")]
        [Display(Name = "Ad")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyisim alanı boş geçilemez")]
        [Display(Name = "Soyad")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email alanı boş geçilemez")]
        [EmailAddress(ErrorMessage = "Email formatı uygun değil")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Tekrar şifresi boş geçilemez")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor!")]
        [Display(Name = "Şifre Tekrar")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Adres alanı boş geçilemez")]
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Ehliyet resim alanı boş geçilemez")]
        [Display(Name = "Ehliyet")]
        public string DriverLicence { get; set; }
        [Required(ErrorMessage = "Kart numarası boş geçilemez")]
        [Display(Name = "Kart Numarası")]
        public string CardNumber { get; set; }
        [Required(ErrorMessage = "Kart sahibinin adı boş geçilemez")]
        [Display(Name = "Kart Sahibinin Adı")]
        public string CardFullName { get; set; }
        [Required(ErrorMessage = "Kartın geçerlilik tarihi boş geçilemez")]
        [Display(Name = "Kartın Geçerlilik Tarihi")]
        public string ExpireDate { get; set; }
        [Required(ErrorMessage = "Kartın cvv alanı boş geçilemez")]
        [Display(Name = "Kart CVV Numarası")]
        public string CvvNumber { get; set; }

    }
}
