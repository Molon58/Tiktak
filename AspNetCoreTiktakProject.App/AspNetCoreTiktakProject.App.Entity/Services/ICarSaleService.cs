using AspNetCoreTiktakProject.App.Entity.Entity;
using AspNetCoreTiktakProject.App.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Entity.Services
{
    public interface ICarSaleService
    {
        Task<CarSaleViewModel> Get(int id);
        
        Task SaleSave(int id, string userName);
        Task Add(CarSale carSale);

        Task EndDrive (BillViewModel model, string userName);

        

    }
}
