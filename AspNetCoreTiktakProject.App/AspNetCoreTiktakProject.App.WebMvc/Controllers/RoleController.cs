using AspNetCoreTiktakProject.App.Entity.Services;
using AspNetCoreTiktakProject.App.Entity.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTiktakProject.App.WebMvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class RoleController : Controller
    {
        private readonly IAccountService _service;

        public RoleController(IAccountService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var roles = await _service.GetAllRoles();
            return View(roles);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleViewModel model)
        {
            string msg = await _service.CreateRoleAsync(model);

            if (msg == "OK")
            {
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", msg);
            }

            return View(model);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var model = await _service.GetAllUsersWithRole(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditRoleViewModel model)
        {
            string msg = await _service.EditRoleListAsync(model);
            if (msg != "OK")
            {
                ModelState.AddModelError("", msg);
                return View(model);
            }

            return RedirectToAction("Edit", "Role", new { Id = model.RoleId });
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteRoles(id);
            return PartialView("_RolesPartialView", await _service.GetAllRoles());
        }
    }
}
