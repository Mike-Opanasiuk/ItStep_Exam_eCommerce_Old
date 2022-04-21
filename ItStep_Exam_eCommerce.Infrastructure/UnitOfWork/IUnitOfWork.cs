using ItStep_Exam_eCommerce.Infrastructure.UnitOfWork.Repositories.Abstract;

namespace ItStep_Exam_eCommerce.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }

        Task<int> SaveChangesAsync();
    }
}
