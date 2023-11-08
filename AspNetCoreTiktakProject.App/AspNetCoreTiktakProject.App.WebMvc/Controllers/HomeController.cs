using AspNetCoreTiktakProject.App.Entity.Services;
using AspNetCoreTiktakProject.App.Entity.ViewModels;
using AspNetCoreTiktakProject.App.WebMvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;

namespace AspNetCoreTiktakProject.App.WebMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IContactService _service;
        private readonly IBillService _billService;

        public HomeController(ILogger<HomeController> logger, IContactService service, IBillService billService)
        {
            _logger = logger;
            _service = service;
            _billService = billService;
        }

        public IActionResult Index()
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
        
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(ContactViewModel contact)
        {
            await _service.ContactAdd(contact);
            return RedirectToAction("Index");
        }

        [Authorize]
        public async Task<IActionResult> BillUser()
        {
            var bills = await _billService.GetBills(User.Identity.Name);

            return View(bills);
        }

    }
}