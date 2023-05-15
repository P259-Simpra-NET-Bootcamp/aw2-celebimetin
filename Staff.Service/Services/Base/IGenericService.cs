using System.Linq.Expressions;

namespace Staff.Service.Services.Base
{
    public interface IGenericService<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}