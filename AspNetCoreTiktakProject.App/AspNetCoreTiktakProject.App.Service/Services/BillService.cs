using AspNetCoreTiktakProject.App.DataAccess.Identities;
using AspNetCoreTiktakProject.App.Entity.Entity;
using AspNetCoreTiktakProject.App.Entity.Services;
using AspNetCoreTiktakProject.App.Entity.UnitOfWorks;
using AspNetCoreTiktakProject.App.Entity.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Service.Services
{
    public class BillService : IBillService
    {
        private readonly IUnitOfWorks _uow;
        private readonly IMapper _mapper;
        private readonly IAccountService _accountService;
        


        public BillService(IUnitOfWorks uow, IMapper mapper, IAccountService accountService)
        {
            _uow = uow;
            _mapper = mapper;
            _accountService = accountService;
            
        }

        public async Task<BillViewModel> Get(int id)
        {
            var billdetails = await _uow.GetRepository<Bill>().Get(x => x.Id == id);

            return _mapper.Map<BillViewModel>(billdetails);
        }

        public async Task<List<BillViewModel>> GetAll()
        {
            var list = await _uow.GetRepository<Bill>().GetAllAsync();
            return  _mapper.Map<List<BillViewModel>>(list);
        }


        public async Task<List<BillViewModel>> GetBills( int id)
        {
            var user = await _accountService.GetUser(id);
           
            var list = await _uow.GetRepository<Bill>().GetAll(x=>x.CustomerId==user.Id,x=>x.OrderBy(x=>x.OccuredDate),x=>x.CarSale, x => x.CarProperty);
            
            var listall=_mapper.Map<List<BillViewModel>>(list);
            foreach (var item in listall)
            {
                item.CustomerName=user.FirstName;
                item.CustomerLastName=user.LastName;
                item.Email=user.Email;
                item.Address=user.Address;
                item.CardFullName=user.CardFullName;
                item.CardNumber=user.CardNumber;
                item.CvvNumber=user.CvvNumber;
                item.ExpireDate=user.ExpireDate;
            }
            return listall;
        }

        public async Task<List<BillViewModel>> GetBills(string username)
        {
            var user = await _accountService.Find(username);

            var list = await _uow.GetRepository<Bill>().GetAll(x => x.CustomerId == user.Id, x => x.OrderBy(x => x.OccuredDate), x => x.CarSale, x => x.CarProperty);

            var listall = _mapper.Map<List<BillViewModel>>(list);
            foreach (var item in listall)
            {
                item.CustomerName = user.FirstName + " " + user.LastName;
                item.CardFullName = user.CardFullName;
                item.CardNumber= user.CardNumber;
            }
            return listall;
        }
    }
}
