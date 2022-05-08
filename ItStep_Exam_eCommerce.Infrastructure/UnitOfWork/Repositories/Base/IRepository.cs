using ItStep_Exam_eCommerce.Core.Entities.Abstract;

namespace ItStep_Exam_eCommerce.Infrastructure.UnitOfWork.Repositories.Base
{
    public interface IRepository<TEntity, TKey> where TEntity : IEntity
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> FindAsync(TKey id);
        Task<TEntity> InsertAsync(TEntity entity);
        TEntity Update(TEntity entity);
        Task DeleteAsync(TKey id);
    }
}
