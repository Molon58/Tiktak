﻿using AspNetCoreTiktakProject.App.Entity.Services;
using AspNetCoreTiktakProject.App.Entity.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTiktakProject.App.WebMvc.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _service;

        public AccountController(IAccountService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)      //Kullanıcının kaydını oluşturmak ve kayıt işleminin sonucuna göre yönlendirme veya hata mesajı eklemektir.
        {
            string msg = await _service.CreateUserAsync(model);

            if (msg == "OK")
            {
                return RedirectToAction("Login");
            }
            else
            {
                ModelState.AddModelError("", msg);
            }

            return View(model);
        }
        //Kullanıcıyı oturum açma sayfasına yönlendiren bir işlem gerçekleştirir. 
        public IActionResult Login(string? returnUrl)
        {
            LoginViewModel model = new LoginViewModel()
            {
                ReturnUrl = returnUrl
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var msg = await _service.Login(model);

            if (msg == "user not found")
            {
                ModelState.AddModelError("", "Kullanıcı bulunamadı.");
                return View(model);
            }
            else if (msg == "OK")
            {
                return Redirect(model.ReturnUrl ?? "~/");
            }
            else
            {
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
            }
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await _service.LogoutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
