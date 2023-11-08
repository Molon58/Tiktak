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
        Task<List<RoleViewModel>> GetAllRoles();
        Task<RoleViewModel> FindByIdAsync(string id);
        Task<UsersInOrOutViewModel> GetAllUsersWithRole(string id);
        Task<string> EditRoleListAsync(EditRoleViewModel model);
        Task<UserViewModel> Find(string email);
        Task<List<UserViewModel>> GetAllUsers();
        Task<UserViewModel> GetUser(int id);
        Task UpdateUser(UserViewModel userViewModel);
        Task<UserViewModel> GetUserByUsername(string username);
        Task Delete(int id);
        Task DeleteRoles(int id);

        
        Task LogoutAsync();
    }
}
