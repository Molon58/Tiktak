using AspNetCoreTiktakProject.App.DataAccess.Identities;
using AspNetCoreTiktakProject.App.Entity.Services;
using AspNetCoreTiktakProject.App.Entity.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Service.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IMapper _mapper;
       
        public AccountService(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, SignInManager<AppUser> signInManager, IMapper mapper)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _mapper = mapper;
            
        }
        //Rol Oluşturma
        public async Task<string> CreateRoleAsync(RoleViewModel model)
        {
            string message = string.Empty;
            var role = new AppRole()
            {
                Name = model.Name
            };
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                message = "OK";
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    message = error.Description;
                }
                //ModelState.AddModelError("", "Rol kayıt işlemi gerçekleşmedi.");
            }
            return message;
        }

        //Kullanıcı Oluşturma
        public async Task<string> CreateUserAsync(RegisterViewModel model)
        {
            string message = string.Empty;
            var user = new AppUser()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Address = model.Address,
                DriverLicence = model.DriverLicence,
                CardNumber = model.CardNumber,
                CardFullName = model.CardFullName,
                ExpireDate = model.ExpireDate,
                CvvNumber = model.CvvNumber,
                UserName = model.Email

            };

            var identityResult = await _userManager.CreateAsync(user, model.ConfirmPassword);

            if (identityResult.Succeeded)
            {
                message = "OK";
            }
            else
            {
                foreach (var error in identityResult.Errors)
                {
                    message = error.Description;
                }
            }
            return message;
        }

        //Kullanıcıdan Rol Alma/Verme
        public async Task<string> EditRoleListAsync(EditRoleViewModel model)
        {
            string msg = "OK";
            foreach (var userId in model.UserIdsToAdd ?? new string[] { })
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user != null)
                {
                    var result = await _userManager.AddToRoleAsync(user, model.RoleName);
                    if (!result.Succeeded)
                    {
                        msg = $"{user.Email} role eklenemedi";

                    }
                }
            }
            foreach (var userId in model.UserIdsToDelete ?? new string[] { })
            {
                var user = await _userManager.FindByIdAsync(userId);
                if (user != null)
                {
                    var result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);
                    if (!result.Succeeded)
                    {
                        msg = $"{user.Email} rolden çıkarılamadı";
                    }
                }

            }
            return msg;
        }

        //Rolü Veritabanında Kontrol Etme Rol Varsa çağırır yoksa null verir
        public async Task<RoleViewModel> FindByIdAsync(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            return _mapper.Map<RoleViewModel>(role);
        }

        //Email'e göre kimlik doğrulaması gerçekleştirir. Buna göre giriş çıkış işlemleri yapılır.
        public async Task<string> Login(LoginViewModel model)
        {
            string message = string.Empty;
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                message = "user not found";
                return message;
            }
            var signInResult = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
            if (signInResult.Succeeded)
            {
                message = "OK";
            }
            return message;
        }

        //Rolleri Listeler.
        public async Task<List<RoleViewModel>> GetAllRoles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return _mapper.Map<List<RoleViewModel>>(roles);
        }

        //Belirli bir role atanmış ve atanmamış kullanıcıları listeler.
        public async Task<UsersInOrOutViewModel> GetAllUsersWithRole(string id)
        {
            var role = await this.FindByIdAsync(id);

            var usersInRole = new List<AppUser>();
            var usersOutRole = new List<AppUser>();

            var users = await _userManager.Users.ToListAsync();
            foreach (var user in users)
            {

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    usersInRole.Add(user);  //Bu rolde bulunan kullanıcıların listesi
                }
                else
                {
                    usersOutRole.Add(user); //Bu rolde olmayan kullanıcıların listesi
                }

            }
            UsersInOrOutViewModel model = new UsersInOrOutViewModel()
            {
                Role = _mapper.Map<RoleViewModel>(role),
                UsersInRole = _mapper.Map<List<UserViewModel>>(usersInRole),
                UsersOutRole = _mapper.Map<List<UserViewModel>>(usersOutRole)
            };
            return model;
        }

        //Kullanıcının oturumunu kapatmasını gerçekleştirir. 
        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

        public async Task<UserViewModel> Find(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            return _mapper.Map<UserViewModel>(user);
        }

        public async Task<int?> GetUserIdByUsername(string username)
        {
            var user = await _userManager.FindByNameAsync(username);

            return user.Id;
        }
        public async Task< UserViewModel> GetUserByUsername(string username)/////
        {
            var user = await  _userManager.FindByNameAsync(username);

            return _mapper.Map<UserViewModel>(user);
        }

        public async Task<List<UserViewModel>> GetAllUsers()
        {
            var users = await _userManager.Users.ToListAsync();
            return _mapper.Map<List<UserViewModel>>(users);
        }

        public async Task<UserViewModel> GetUser(int id)
        {
            var userDetails = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == id);

            return _mapper.Map<UserViewModel>(userDetails);
        }

        public async Task UpdateUser(UserViewModel userViewModel)
        {
            var user = await _userManager.FindByIdAsync(userViewModel.Id.ToString());


            user.UserName = userViewModel.Email;
            user.FirstName = userViewModel.FirstName;
            user.LastName = userViewModel.LastName;
            user.Email = userViewModel.Email;
            user.Address = userViewModel.Address;

            await _userManager.UpdateAsync(user);
        }

        public async Task Delete(int id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            await _userManager.DeleteAsync(user);
        }

        public async Task DeleteRoles(int id)
        {
            var roles = await _roleManager.FindByIdAsync(id.ToString());
            await _roleManager.DeleteAsync(roles);
        }
    }
}
    

