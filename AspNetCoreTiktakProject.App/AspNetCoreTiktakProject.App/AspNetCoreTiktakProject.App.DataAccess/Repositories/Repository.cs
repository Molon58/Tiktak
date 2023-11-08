using AspNetCoreTiktakProject.App.DataAccess.Contexts;
using AspNetCoreTiktakProject.App.Entity.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreTiktakProject.App.DataAccess.Repositories
{
    public class Repository<T> : IRepository<T> where T:class,new()
    {
        private readonly TiktakContext _context;
        private DbSet<T> _dbSet;

        public Repository(TiktakContext context, DbSet<T> dbSet)
        {
            _context = context;
            _dbSet = dbSet;
        }

        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            this.Delete(entity);
        }

        public void Delete(T entity)
        {
            if (entity.GetType().GetProperty("IsDeleted") != null)
            {
                entity.GetType().GetProperty("IsDeleted").SetValue(entity, true);
                _dbSet.Update(entity);
            }
            else
            {
                _dbSet.Remove(entity);
            }
        }
        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public  async Task<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<IEnumerable<T>> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, params System.Linq.Expressions.Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _dbSet;
            if (filter != null)
                query = query.Where(filter);
            if (orderby != null)
                query = orderby(query);
            foreach (var table in includes)
            {
                query = query.Include(table);
            }
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();  //Ef verileri takip (modified, deleted, detached gibi) etmiyor.
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public T GetSync(Expression<Func<T, bool>> predicate)
        {
            return  _dbSet.FirstOrDefault(predicate);
        }
    }
}
