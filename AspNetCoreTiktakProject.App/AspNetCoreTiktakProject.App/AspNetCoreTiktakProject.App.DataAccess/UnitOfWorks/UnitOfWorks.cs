using AspNetCoreTiktakProject.App.DataAccess.Contexts;
using AspNetCoreTiktakProject.App.DataAccess.Repositories;
using AspNetCoreTiktakProject.App.Entity.Repositories;
using AspNetCoreTiktakProject.App.Entity.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.DataAccess.UnitOfWorks
{
    public class UnitOfWorks : IUnitOfWorks
    {
        private readonly TiktakContext _context;
        private bool disposed=false;

        public UnitOfWorks(TiktakContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public IRepository<T> GetRepository<T>() where T : class, new()
        {
            DbSet<T> dbSet = _context.Set<T>(); // DbSet<T> nesnesini oluşturduk.
            return new Repository<T>(_context, dbSet); // Repository<T> sınıfını bu DbSet ile oluşturun
        }
    }
}
