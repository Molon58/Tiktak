using AspNetCoreTiktakProject.App.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Entity.Services
{
    public interface IContactService
    {
        Task ContactAdd(ContactViewModel model);
        Task<List<ContactViewModel>> GetAllContact();
        
        Task Delete(int id);
    }
}
