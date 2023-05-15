using Staff.Data.Repositories.Base;
using System.Linq.Expressions;

namespace Staff.Service.Services.Base
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        private readonly IGenericRepository<TEntity> repository;

        public GenericService(IGenericRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public List<TEntity> GetAll()
        {
            var entities = repository.GetAll();
            return entities;
        }
        public TEntity GetById(int id)
        {
            var entity = repository.GetById(id);
            return entity;
        }
        public void Insert(TEntity entity)
        {
            CreatedAt(entity);
            repository.Insert(entity);
            repository.Save();
        }
        public void Update(TEntity entity)
        {
            CreatedAt(entity);
            repository.Update(entity);
            repository.Save();
        }
        public void Delete(int id)
        {
            repository.DeleteById(id);
            repository.Save();
        }
        public IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return repository.Where(predicate).ToList();
        }

        private void CreatedAt(TEntity entity)
        {
            entity.GetType().GetProperty("CreatedAt").SetValue(entity, DateTime.UtcNow);
        }
    }
}