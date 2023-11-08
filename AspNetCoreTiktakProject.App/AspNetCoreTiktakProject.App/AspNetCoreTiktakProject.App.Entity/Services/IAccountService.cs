using AspNetCoreTiktakProject.App.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Entity.Services
{
    public interface IAccountService
    {
        Task<string> CreateUserAsync(RegisterViewModel model);
        Task<string> Login(LoginViewModel model);
        Task<string> CreateRoleAsync(RoleViewModel model);
        Task<int?> GetUserIdByUsername(string username);
        Task<List<RoleViewModel>> GetAllRoles();
        Task<RoleViewModel> FindByIdAsync(string id);
        Task<UsersInOrOutViewModel> GetAllUsersWithRole(string id);
        Task<string> EditRoleListAsync(EditRoleViewModel model);
        Task<UserViewModel> Find(string email);
        Task LogoutAsync();
        Task<UserViewModel> GetUserByUsername(string username);
    }
}
