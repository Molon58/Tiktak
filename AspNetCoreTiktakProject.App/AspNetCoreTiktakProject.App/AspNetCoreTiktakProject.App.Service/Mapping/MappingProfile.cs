using AspNetCoreTiktakProject.App.DataAccess.Identities;
using AspNetCoreTiktakProject.App.Entity.Entity;
using AspNetCoreTiktakProject.App.Entity.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Service.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile() 
        {
           // CreateMap<Car,CarViewModel>().ReverseMap();
            CreateMap<CarProperty, CarPropertyViewModel>().ReverseMap();
            CreateMap<AppRole, RoleViewModel>().ReverseMap();
            CreateMap<AppUser, UserViewModel>().ReverseMap();
            CreateMap<AppUser, LoginViewModel>().ReverseMap();
            CreateMap<CarSale, CarSaleViewModel>().ReverseMap();
            CreateMap<Bill, BillViewModel>().ReverseMap();


        }

    }
}
