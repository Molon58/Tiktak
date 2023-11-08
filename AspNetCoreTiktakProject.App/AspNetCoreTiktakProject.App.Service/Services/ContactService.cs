using AspNetCoreTiktakProject.App.Entity.Entity;
using AspNetCoreTiktakProject.App.Entity.Services;
using AspNetCoreTiktakProject.App.Entity.UnitOfWorks;
using AspNetCoreTiktakProject.App.Entity.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Service.Services
{
    public class ContactService : IContactService
    {
        private readonly IUnitOfWorks _uow;
        private readonly IMapper _mapper;

        public ContactService(IUnitOfWorks uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task ContactAdd(ContactViewModel model)
        {
            await _uow.GetRepository<Contact>().Add(_mapper.Map<Contact>(model));
            await _uow.CommitAsync();
        }

        public async Task Delete(int id)
        {
            _uow.GetRepository<Contact>().Delete(id);
            await _uow.CommitAsync();
        }

       

        public async Task<List<ContactViewModel>> GetAllContact()
        {
            var list = await _uow.GetRepository<Contact>().GetAllAsync();
            return _mapper.Map<List<ContactViewModel>>(list);
        }
    }
}
