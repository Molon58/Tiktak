using AspNetCoreTiktakProject.App.Entity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.Entity.UnitOfWorks
{
    public interface IUnitOfWorks
    {
        IRepository<T> GetRepository<T>() where T : class, new();
        void Commit();      //içine SaveChanges() gelecek.
        Task CommitAsync();
    }
}
