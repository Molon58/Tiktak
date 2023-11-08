using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Entity.ViewModels
{
    public class UserViewModel
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
        [Required(ErrorMessage = "Adres alanı boş geçilemez")]
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Ehliyet alanı boş geçilemez")]
        [Display(Name = "Ehliyet")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Lütfen geçerli bir dosya formatı yükleyiniz.")]
        public string DriverLicence { get; set; }
        [DataType(DataType.CreditCard, ErrorMessage = "Lütfen geçerli bir kart numarası giriniz.")]
        [Required(ErrorMessage = "Kredi kartı numara alanı boş geçilemez")]
        [Display(Name = "Kredi Kartı Numarası")]
        public string CardNumber { get; set; }
        [Required(ErrorMessage = "Kart sahibinin adı boş geçilemez")]
        [Display(Name = "Kart Sahibinin Adı")]
        public string CardFullName { get; set; }
        [DataType(DataType.Text, ErrorMessage = "Lütfen geçerli bir son geçerlilik tarihi girin.")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "Sayı 4 hane olmalıdır.")]
        [Required(ErrorMessage = "Kartın son kullanma tarihi boş geçilemez")]
        [Display(Name = "Kartın Son Kullanma Tarihi")]
        public string ExpireDate { get; set; }
        [DataType(DataType.Text, ErrorMessage = "Lütfen geçerli bir Cvv numarası girin.")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "Sayı 3 hane olmalıdır.")]
        [Required(ErrorMessage = "Cvv numara alanı boş geçilemez")]
        [Display(Name = "Cvv Numarası")]
        public string CvvNumber { get; set; }
    }
}
