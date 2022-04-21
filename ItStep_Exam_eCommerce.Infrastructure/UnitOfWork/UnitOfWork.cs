using ItStep_Exam_eCommerce.Infrastructure.Data;
using ItStep_Exam_eCommerce.Infrastructure.UnitOfWork.Repositories;
using ItStep_Exam_eCommerce.Infrastructure.UnitOfWork.Repositories.Abstract;

namespace ItStep_Exam_eCommerce.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext context;

        public IUserRepository UserRepository { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            UserRepository = new UserRepository(context);
            this.context = context;
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            context.Dispose();   
        }
    }
}
