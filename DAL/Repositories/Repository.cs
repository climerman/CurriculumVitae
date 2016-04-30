using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext DbContext { get; set; }
        protected IDbSet<T> DbSet { get; set; }

        public Repository(IDbContext dbContext)
        {
            if (dbContext == null) throw new ArgumentNullException(nameof(dbContext));
            DbContext = dbContext as DbContext;
            if (DbContext != null) DbSet = DbContext.Set<T>();
        }

        public void Add(T obj)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(obj);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Added;
            }
            else
            {
                DbSet.Add(obj);
            }
        }

        public void Delete(T obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public T Get(int id) => DbSet.Find(id);

        public List<T> GetAll() => DbSet.ToList(); 

        public void Update(T obj)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(obj);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                DbSet.Attach(obj);
            }
            dbEntityEntry.State = EntityState.Modified;
        }
    }
}