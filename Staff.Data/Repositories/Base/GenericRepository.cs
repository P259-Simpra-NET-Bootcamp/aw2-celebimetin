using Microsoft.EntityFrameworkCore;
using Staff.Data.Context;
using System.Linq.Expressions;

namespace Staff.Data.Repositories.Base
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly StaffDbContext context;
        private readonly DbSet<T> dbSet;

        public GenericRepository(StaffDbContext context)
        {
            this.context = context;
            dbSet = context.Set<T>();
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }
        public T GetById(int id)
        {
            return dbSet.Find(id);
        }
        public void Insert(T entity)
        {
            dbSet.Add(entity);
        }
        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }
        public void DeleteById(int id)
        {
            var deleteEntity = dbSet.Find(id);
            dbSet.Remove(deleteEntity);
        }
        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}