using AspNetCoreTiktakProject.App.DataAccess.Identities;
using AspNetCoreTiktakProject.App.Entity.Entity;
using AspNetCoreTiktakProject.App.Entity.Services;
using AspNetCoreTiktakProject.App.Entity.UnitOfWorks;
using AspNetCoreTiktakProject.App.Entity.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Service.Services
{
    public class CarSaleService : ICarSaleService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWorks _uow;
        private readonly IAccountService _accountService;
        private readonly UserManager<AppUser> _userManager;
        public CarSaleService(IMapper mapper, IUnitOfWorks uow, IAccountService accountService, UserManager<AppUser> userManager)
        {
            _mapper = mapper;
            _uow = uow;
            _accountService = accountService;
            _userManager = userManager;
        }

        public async Task Add(CarSale carSale)
        {

            var carSaleViewModel = _mapper.Map<CarSaleViewModel>(carSale);
            await _uow.GetRepository<CarSaleViewModel>().Add(carSaleViewModel);///
            await _uow.CommitAsync();
        }
        //KİRALAMA BURADAN BASLIYOR ....
        public async Task SaleSave(int id, string userName)
        {
            var user = await _accountService.GetUserByUsername(userName);
            
            Car car = _uow.GetRepository<Car>().GetSync(c => c.Id == id);
            
            {


                CarSale sale = new CarSale()
                {
                    CarId = car.Id,
                    CustomerId = user.Id,
                    StartedPoint = car.Location,
                    StartedTime = DateTime.Now

                };

                car.IsActive = false;
                await _uow.GetRepository<CarSale>().Add(sale);
            }
            
            
            await _uow.CommitAsync();

            
            
            
        }

        public async Task<CarSaleViewModel> Get(int id)
        {
            var carSale = await _uow.GetRepository<CarSaleViewModel>().GetById(id);
            return _mapper.Map<CarSaleViewModel>(carSale);
        }

        public async Task EndDrive(BillViewModel? model, string userName )
        {
            var user = await _accountService.GetUserByUsername(userName);

            IEnumerable<CarSale> carSales = await _uow.GetRepository<CarSale>().GetAll(cs => cs.CustomerId==user.Id);
           int carSaleId= carSales.Max(x => x.Id);
            CarSale carSale =  _uow.GetRepository<CarSale>().GetSync(cs => cs.Id==carSaleId);
            Car car = _uow.GetRepository<Car>().GetSync(c => c.Id==model.CarSaleId);
            CarProperty cp = _uow.GetRepository<CarProperty>().GetSync(cp => cp.CarId==model.CarSaleId); //carsaleıd aslında carıd

            Bill bill = new Bill()
            {
                OccuredDate = DateTime.Now,
                FinishedTime = DateTime.Now,

                DestinationPoint = model.DestinationPoint,
                Price = (((DateTime.Now - (carSale.StartedTime)).Minutes) * cp.MinutePrice)+cp.MinutePrice,
                CustomerId = user.Id,
                CarSaleId = carSale.Id,
                VirtualPosId=user.Id
                

            };
            car.Location = bill.DestinationPoint;
            car.IsActive = true;
            

            await _uow.GetRepository<Bill>().Add(bill);
            await _uow.CommitAsync();
            
            

        }
    }
}
