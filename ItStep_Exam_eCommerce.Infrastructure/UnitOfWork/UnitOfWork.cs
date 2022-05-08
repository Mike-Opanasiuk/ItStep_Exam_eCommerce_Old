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

        public async Task<int> SaveChangesAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();   
        }
    }
}
