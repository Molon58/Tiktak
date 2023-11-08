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
        [Required(ErrorMessage = "Ehliyet alanı boş geçilemez")]
        [Display(Name = "Ehliyet")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Lütfen geçerli bir dosya formatı yükleyiniz.")]
        public string DriverLicence { get; set; }
        [DataType(DataType.CreditCard, ErrorMessage = "Lütfen geçerli bir kart numarası giriniz.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Kredi kartı numarası sadece rakamlardan oluşmalıdır.")]
        [Required(ErrorMessage = "Kredi kartı numara alanı boş geçilemez")]
        [Display(Name = "Kredi Kartı Numarası")]
        public string CardNumber { get; set; }
        [Required(ErrorMessage = "Kart sahibinin adı boş geçilemez")]
        [RegularExpression("^[a-zA-Z\\s]*$", ErrorMessage ="Lütfen geçerli format giriniz(A-Z a-z)")]
        [Display(Name = "Kart Sahibinin Adı")]
        public string CardFullName { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Son geçerlilik tarihi sadece rakamlardan oluşmalıdır.")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "Sayı 4 hane olmalıdır.")]
        [Required(ErrorMessage = "Kartın son kullanma tarihi boş geçilemez")]
        [Display(Name = "Kartın Son Kullanma Tarihi")]
        public string ExpireDate { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Cvv sadece rakamlardan oluşmalıdır.")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "Sayı 3 hane olmalıdır.")]
        [Required(ErrorMessage = "Cvv numara alanı boş geçilemez")]
        [Display(Name = "Cvv Numarası")]
        public string CvvNumber { get; set; }

    }
}
