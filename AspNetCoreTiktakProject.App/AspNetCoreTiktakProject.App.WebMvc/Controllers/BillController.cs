using AspNetCoreTiktakProject.App.Entity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AspNetCoreTiktakProject.App.WebMvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class BillController : Controller
    {
        private readonly IBillService _billService;

        public BillController(IBillService billService)
        {
            _billService = billService;
        }

        public async Task<IActionResult> Index()
        {
            var bill = await _billService.GetAll();
            return View(bill);
        }

        public async Task<IActionResult> Details(int id) 
        { 
             var model = await _billService.GetBills(id);
            return View(model);
        }
    }
}
