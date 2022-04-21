using ItStep_Exam_eCommerce.Core.Entities.Abstract;
using ItStep_Exam_eCommerce.Infrastructure.Data;

namespace ItStep_Exam_eCommerce.Infrastructure.UnitOfWork.Repositories.Base
{
    public abstract class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : IEntity
    {
        protected ApplicationDbContext Context { get; }

        public Repository(ApplicationDbContext context)
        {
            Context = context;
        }

        public virtual Task<TEntity> FindAsync(TKey id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<TEntity> InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task DeleteAsync(TKey id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
