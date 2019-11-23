using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TSheet.Core.Domain;

namespace TSheet.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private DbContext _context;
        private DbSet<TEntity> _dbset;

        public Repository(DbContext context)
        {
            _context = context;
            _dbset = _context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
        }

        public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null) return _dbset.AsQueryable();

            return _dbset.Where(filter);
        }

        public void Remove(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
