using ItStep_Exam_eCommerce.Core.Entities.Abstract;
using ItStep_Exam_eCommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace ItStep_Exam_eCommerce.Infrastructure.UnitOfWork.Repositories.Base
{
    public abstract class Repository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class, IEntity
    {
        protected ApplicationDbContext Context { get; }

        public Repository(ApplicationDbContext context)
        {
            Context = context;
        }

        public virtual async Task<TEntity> FindAsync(TKey id)
        {
            return await Context.FindAsync<TEntity>(id);
        }

        public virtual async Task<TEntity> InsertAsync(TEntity entity)
        {
            var inserted = await Context.Set<TEntity>().AddAsync(entity);
            return inserted.Entity;
        }

        public virtual TEntity Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public virtual async Task DeleteAsync(TKey id)
        {
            Context.Remove(await FindAsync(id));
        }

        public IQueryable<TEntity> GetAll()
        {
            return Context.Set<TEntity>();
        }
    }
}
