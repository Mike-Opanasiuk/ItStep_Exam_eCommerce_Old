using ItStep_Exam_eCommerce.Core.Entities;

namespace ItStep_Exam_eCommerce.Infrastructure.UnitOfWork.Repositories.Abstract
{
    public interface IProductRepository
    {
        IQueryable<ProductEntity> GetAll();
        Task<ProductEntity> FindAsync(Guid id);
        Task<ProductEntity> InsertAsync(ProductEntity entity);
        ProductEntity Update(ProductEntity entity);
        Task DeleteAsync(Guid id);
    }
}
