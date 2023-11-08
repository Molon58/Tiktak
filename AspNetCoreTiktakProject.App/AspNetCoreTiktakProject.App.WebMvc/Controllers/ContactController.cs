using AspNetCoreTiktakProject.App.Entity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AspNetCoreTiktakProject.App.WebMvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        private readonly IContactService _service;

        public ContactController(IContactService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var contacts = await _service.GetAllContact();
            return View(contacts);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return PartialView("_ContactsPartialView", await _service.GetAllContact());
        }

    }
}
