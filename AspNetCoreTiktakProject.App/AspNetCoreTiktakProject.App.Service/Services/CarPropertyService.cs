using AspNetCoreTiktakProject.App.Entity.Entity;
using AspNetCoreTiktakProject.App.Entity.Services;
using AspNetCoreTiktakProject.App.Entity.UnitOfWorks;
using AspNetCoreTiktakProject.App.Entity.ViewModels;
using AutoMapper;
using AutoMapper.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Service.Services
{
    public class CarPropertyService : ICarPropertyService
    {
        private readonly IUnitOfWorks _uow;
        private readonly IMapper _mapper;

        public CarPropertyService(IUnitOfWorks uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<CarPropertyViewModel> Get(int id)
        {
            var carDetails = await _uow.GetRepository<CarProperty>().Get(x=>x.Id==id);
            
            return _mapper.Map<CarPropertyViewModel>(carDetails);
        }

        public async Task<List<CarPropertyViewModel>> GetAll()
        {
            
             var list =await _uow.GetRepository<CarProperty>().GetAll(x=>x.IsActive==true);
            
            return _mapper.Map<List<CarPropertyViewModel>>(list);
        }

        public async Task<List<CarPropertyViewModel>> GetByFuelType(string fuelType)
        {
            var filteredCars = await _uow.GetRepository<CarProperty>().GetAll(x=>x.FuelType==fuelType);
            
            
            return _mapper.Map<List<CarPropertyViewModel>>(filteredCars);
        }
        public async Task<List<CarPropertyViewModel>> GetByGearType(string gearType)
        {
            var filteredByGearCars = await _uow.GetRepository<CarProperty>().GetAll(x=>x.GearType==gearType);
            
            return _mapper.Map<List<CarPropertyViewModel>>(filteredByGearCars);

        }

        public async Task<List<CarPropertyViewModel>> GetByFuelTypeAndGearType(string fuelType, string gearType)
        {
            var filteredCars = await _uow.GetRepository<CarProperty>().GetAll(x=>x.FuelType==fuelType&&x.GearType==gearType);
           
            return _mapper.Map<List<CarPropertyViewModel>>(filteredCars);
  
        }

        

		public async Task<List<CarPropertyViewModel>> GetByLocation(string location)
		{
            //Car car = _uow.GetRepository<Car>().GetSync(c => c.Location==location);

            var cars = await _uow.GetRepository<CarProperty>().GetAll(x=>x.Location==location);
            return _mapper.Map<List<CarPropertyViewModel>>(cars);
		}

        public async Task<List<CarPropertyViewModel>> GetByFuelTypeAndGearTypeAndLocation(string fuelType, string gearType, string location)
        {
            var filteredCars = await _uow.GetRepository<CarProperty>().GetAll(x=>x.FuelType==fuelType&&x.Location==location&&x.GearType==gearType);
           
            return _mapper.Map<List<CarPropertyViewModel>>(filteredCars);
        }

        public async Task<List<CarPropertyViewModel>> GetByFuelTypeAndLocationType(string fuelType, string location)
        {
            var filteredCars = await _uow.GetRepository<CarProperty>().GetAll(x=>x.FuelType==fuelType&&x.Location==location);
            
            return _mapper.Map<List<CarPropertyViewModel>>(filteredCars);
        }

        public async Task<List<CarPropertyViewModel>> GetByGearTypeAndLocationType(string gearType, string location)
        {
            var filteredCars = await _uow.GetRepository<CarProperty>().GetAll(x=>x.GearType==gearType&&x.Location==location);
            
            return _mapper.Map<List<CarPropertyViewModel>>(filteredCars);
        }

        public async Task CreateCarAsync(CarPropertyViewModel model)
        {
            await _uow.GetRepository<CarProperty>().Add(_mapper.Map<CarProperty>(model));
            await _uow.CommitAsync();
        }

        public async Task Update(CarPropertyViewModel model)
        {
            _uow.GetRepository<CarProperty>().Update(_mapper.Map<CarProperty>(model));
            await _uow.CommitAsync();
        }

        public async Task Delete(int id)
        {
            _uow.GetRepository<CarProperty>().Delete(id);
            await _uow.CommitAsync();
        }

        public async Task<List<CarPropertyViewModel>> GetAllAdmin()
        {
            var list=await _uow.GetRepository<CarProperty>().GetAllAsync();
            return _mapper.Map<List<CarPropertyViewModel>>(list);

        }
    }
}
