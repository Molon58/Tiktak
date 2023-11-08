using AspNetCoreTiktakProject.App.Entity.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Entity.ViewModels
{
    public class CarPropertyViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Marka boş geçilemez")]
        [Display(Name = "Marka")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Model boş geçilemez")]
        [Display(Name = "Model")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Yakıt tipi boş geçilemez")]
        [Display(Name = "Yakıt Tipi")]
        public string FuelType { get; set; }
        [Required(ErrorMessage = "Vites türü boş geçilemez")]
        [Display(Name = "Vites Türü")]
        public string GearType { get; set; }
        [Required(ErrorMessage = "Ana resim boş geçilemez")]
        [Display(Name = "Ana Resim")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Detay resim boş geçilemez")]
        [Display(Name = "Detay")]
        public string? ImageDetailUrl1 { get; set; }
        [Required(ErrorMessage = "Detay resim boş geçilemez")]
        [Display(Name = "Detay")]
        public string? ImageDetailUrl2 { get; set; }
        [Required(ErrorMessage = "Detay resim boş geçilemez")]
        [Display(Name = "Detay")]

        public string? ImageDetailUrl3 { get; set; }
        [Required(ErrorMessage = "Detay resim boş geçilemez")]
        [Display(Name = "Detay")]

        public string? ImageDetailUrl4 { get; set; }
        [Required(ErrorMessage = "Plaka boş geçilemez")]
        [Display(Name = "Plaka")]
        public string? Plaque { get; set; }
        [Required(ErrorMessage = "Yolcu kapasitesi boş geçilemez")]
        [Display(Name = "Yolcu kapasitesi")]
        public int TotalPerson { get; set; }
        [Required(ErrorMessage = "Bagaj türü boş geçilemez")]
        [Display(Name = "Bagaj Türü")]
        public string? Baggage { get; set; }
        [Required(ErrorMessage = "Dakika ücreti boş geçilemez")]
        [Display(Name = "Dakika ücreti")]
        public decimal MinutePrice { get; set; }
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "Lokasyon boş geçilemez")]
        [Display(Name = "Lokasyon")]
        public string Location { get; set; }
        public int CarSaleId { get; set; }
        //LİST ALLL CAR DİYECEĞİZZZ....



        //public int CarId { get; set; } // foreign key
    }
}
