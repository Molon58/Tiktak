using AspNetCoreTiktakProject.App.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Entity.Services
{
    public interface IBillService
    {
        Task<List<BillViewModel>> GetBills(int id);
        Task<List<BillViewModel>> GetBills(string username);
        Task<List<BillViewModel>> GetAll();
        Task<BillViewModel> Get(int id);
       
    }
}
