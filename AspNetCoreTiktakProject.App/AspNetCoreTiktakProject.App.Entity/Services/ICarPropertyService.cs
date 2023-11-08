using AspNetCoreTiktakProject.App.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Entity.Services
{
    public interface ICarPropertyService
    {
        Task<List<CarPropertyViewModel>> GetAll();
        Task<List<CarPropertyViewModel>> GetAllAdmin();




        Task<List<CarPropertyViewModel>> GetByFuelType(string fuelType);
        Task<List<CarPropertyViewModel>> GetByGearType(string gearType);
        Task<List<CarPropertyViewModel>> GetByLocation(string location);
        Task<List<CarPropertyViewModel>> GetByFuelTypeAndGearType(string fuelType, string gearType);
        Task<List<CarPropertyViewModel>> GetByFuelTypeAndLocationType(string fuelType, string location);
        Task<List<CarPropertyViewModel>> GetByGearTypeAndLocationType(string gearType, string location);


        Task<List<CarPropertyViewModel>> GetByFuelTypeAndGearTypeAndLocation(string fuelType, string gearType, string location);

        Task<CarPropertyViewModel> Get(int id);
        Task CreateCarAsync(CarPropertyViewModel model);
        Task Update(CarPropertyViewModel model);
        
        Task Delete(int id);

    }
}
