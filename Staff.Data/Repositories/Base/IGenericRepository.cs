using System.Linq.Expressions;

namespace Staff.Data.Repositories.Base
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        IQueryable<T> Where(Expression<Func<T, bool>> predicate);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteById(int id);
        void Save();
    }
}