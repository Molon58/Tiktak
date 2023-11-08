using AspNetCoreTiktakProject.App.Entity.Services;
using AspNetCoreTiktakProject.App.Entity.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AspNetCoreTiktakProject.App.WebMvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly IAccountService _service;
        public UserController(IAccountService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index(string search)
        {
            var users = await _service.GetAllUsers();
            if (search != null)
            {
                users = users.Where(u => u.FirstName.ToLower().Contains(search.ToLower())).ToList();
            }
            return View(users);
        }

        public async Task<IActionResult> Details(int id)
        {
            var model = await _service.GetUser(id);

            return View(model);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var model = await _service.GetUser(id);
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(UserViewModel model)
        {
            await _service.UpdateUser(model);
            return RedirectToAction("Details", new { id = model.Id });
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return PartialView("_UsersPartialView", await _service.GetAllUsers());
        }
    }
}
