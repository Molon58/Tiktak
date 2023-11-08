using AspNetCoreTiktakProject.App.DataAccess.Identities;
using AspNetCoreTiktakProject.App.Entity.Entity;
using AspNetCoreTiktakProject.App.Entity.Services;
using AspNetCoreTiktakProject.App.Entity.ViewModels;
using AspNetCoreTiktakProject.App.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AspNetCoreTiktakProject.App.WebMvc.Controllers
{
    public class SaleController : Controller
    {
        private readonly ICarPropertyService _carPropertyService;
        private readonly ICarSaleService _carSaleService;
        private readonly IAccountService _accountService;
        private readonly UserManager<AppUser> _userManager;

        public SaleController(ICarPropertyService carPropertyService, ICarSaleService carSaleService, IAccountService accountService, UserManager<AppUser> userManager)
        {
            _carPropertyService = carPropertyService;
            _carSaleService = carSaleService;
            _accountService = accountService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _carPropertyService.GetAll();
            return View(list);
        }
        [HttpPost]
        public async Task<IActionResult> Index(string fuelType, string gearType, string location)
        {
            var filteredCars = await _carPropertyService.GetAll();

            // Sadece lokasyon seçildiyse
            if (!string.IsNullOrWhiteSpace(fuelType) && !string.IsNullOrWhiteSpace(gearType))
            {
                filteredCars = await _carPropertyService.GetByFuelTypeAndGearType(fuelType, gearType);
            }
            // Yakıt tipi ve lokasyon seçildiyse
            if (!string.IsNullOrWhiteSpace(fuelType) && !string.IsNullOrWhiteSpace(location))
            {
                filteredCars = await _carPropertyService.GetByFuelTypeAndLocationType(fuelType, location);
            }
            // Vites tipi ve lokasyon seçildiyse
            if (!string.IsNullOrWhiteSpace(gearType) && !string.IsNullOrWhiteSpace(location))
            {
                filteredCars = await _carPropertyService.GetByGearTypeAndLocationType(gearType, location);
            }
            // Sadece lokasyon seçildiyse
            if (!string.IsNullOrWhiteSpace(location))
            {
                filteredCars = await _carPropertyService.GetByLocation(location);
            }
            // Sadece yakıt tipi seçildiyse
            if (!string.IsNullOrWhiteSpace(fuelType))
            {
                filteredCars = await _carPropertyService.GetByFuelType(fuelType);
            }
            // Sadece vites tipi seçildiyse
            if (!string.IsNullOrWhiteSpace(gearType))
            {
                filteredCars = await _carPropertyService.GetByGearType(gearType);
            }
            // Diğer durumlar için varsayılan olarak tüm arabaları getir

            return View(filteredCars);


        }
        public async Task<IActionResult> Rent(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var user = await _userManager.FindByIdAsync(userId);
            //if (user.IsOnDrive = true)
            //{
            //    ViewBag.DrivedMessage = "Aktif sürüşünüz bulunmaktadır.";
            //}

            var result = await _carPropertyService.Get(id);

            //var resultList = new List<CarPropertyViewModel> { result };

            return View(result);
        }

        [Authorize]
        public async Task<IActionResult> RentPost(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);


            //var user = User.Identity.IsAuthenticated;
            var user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                await _carSaleService.SaleSave(id, User.Identity.Name);
                user.IsOnDrive = true;

                return RedirectToAction("EndRent", new { id = id });
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }



        }
        public IActionResult EndRent(int id)
        {
            ViewBag.CarId = id;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EndRent(BillViewModel model)
        {
            await _carSaleService.EndDrive(model, User.Identity.Name);
            return RedirectToAction("Index");
        }

















    }
}
