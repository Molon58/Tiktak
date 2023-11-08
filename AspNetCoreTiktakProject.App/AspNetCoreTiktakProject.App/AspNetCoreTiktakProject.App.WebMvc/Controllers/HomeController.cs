using AspNetCoreTiktakProject.App.WebMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspNetCoreTiktakProject.App.WebMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult SSS()
        {
            return View();
        }
        public IActionResult TermAndConditions()
        {
            return View();
        }
        public IActionResult ReturnAndRefund()
        {
            return View();
        }
        public IActionResult PrivatePolicy ()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

    }
}