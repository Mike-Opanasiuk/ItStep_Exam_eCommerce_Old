using ItStep_Exam_eCommerce.Core.Entities;

namespace ItStep_Exam_eCommerce.Infrastructure.UnitOfWork.Repositories.Abstract
{
    public interface IUserRepository
    {
        IQueryable<AppUser> GetAll();
        Task<AppUser> FindAsync(Guid id);
        Task<AppUser> InsertAsync(AppUser entity);
        AppUser Update(AppUser entity);
        Task DeleteAsync(Guid id);
    }
}
