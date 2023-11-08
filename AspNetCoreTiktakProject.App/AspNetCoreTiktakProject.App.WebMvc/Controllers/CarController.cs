using AspNetCoreTiktakProject.App.Entity.Services;
using AspNetCoreTiktakProject.App.Entity.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AspNetCoreTiktakProject.App.WebMvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CarController : Controller
    {

        private readonly ICarPropertyService _service;
        public CarController(ICarPropertyService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index(string search)
        {
            var cars = await _service.GetAllAdmin();

            if (search != null)
            {
                cars = cars.Where(c => c.Plaque.ToLower().Contains(search.ToLower())).ToList();
            }

            return View(cars);
        }
        public async Task<IActionResult> IsActive(int id)
        {
            var car = await _service.Get(id);
            if (car.IsActive == true)
            {
                car.IsActive = false;
            }
            else
            {
                car.IsActive = true;
            }
            await _service.Update(car);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var model = await _service.Get(id);

            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CarPropertyViewModel car, IFormFile formFile1, IFormFile formFile2, IFormFile formFile3, IFormFile formFile4, IFormFile formFile5)
        {
            var path1 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\carimages", formFile1.FileName);
            var path2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\carimages", formFile2.FileName);
            var path3 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\carimages", formFile3.FileName);
            var path4 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\carimages", formFile4.FileName);
            var path5 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\carimages", formFile5.FileName);
            var stream1 = new FileStream(path1, FileMode.Create);
            var stream2 = new FileStream(path2, FileMode.Create);
            var stream3 = new FileStream(path3, FileMode.Create);
            var stream4 = new FileStream(path4, FileMode.Create);
            var stream5 = new FileStream(path5, FileMode.Create);
            formFile1.CopyTo(stream1);
            formFile2.CopyTo(stream2);
            formFile3.CopyTo(stream3);
            formFile4.CopyTo(stream4);
            formFile5.CopyTo(stream5);
            car.ImageUrl = "/carimages/" + formFile1.FileName /*+ model.Id*/;    //Yüklenen resim isimlerinde çakışma olmaması için ismin sonuna uniq id bilgisini ekliyoruz
            car.ImageDetailUrl1 = "/carimages/" + formFile2.FileName;
            car.ImageDetailUrl2 = "/carimages/" + formFile3.FileName;
            car.ImageDetailUrl3 = "/carimages/" + formFile4.FileName;
            car.ImageDetailUrl4 = "/carimages/" + formFile5.FileName;

            car.IsActive = true;
            await _service.CreateCarAsync(car);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return PartialView("_CarsPartialView", await _service.GetAllAdmin());
        }

    }
}
