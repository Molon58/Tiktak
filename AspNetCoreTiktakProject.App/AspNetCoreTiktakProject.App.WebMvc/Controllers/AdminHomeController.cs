using AspNetCoreTiktakProject.App.Entity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTiktakProject.App.WebMvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminHomeController : Controller
    {
        private readonly IAccountService _userservice;

        public AdminHomeController(IAccountService user)
        {
            _userservice = user;
        }

        public IActionResult Index()
        {
            var users = _userservice.GetAllUsers().Result.Count();
            ViewBag.Users = users;

            return View();
        }
    }
}
