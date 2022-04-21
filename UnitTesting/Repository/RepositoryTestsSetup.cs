using ItStep_Exam_eCommerce.Infrastructure.Data;
using ItStep_Exam_eCommerce.Infrastructure.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace UnitTesting.Repository
{
    public class RepositoryTestsSetup
    {
        protected IUnitOfWork UnitOfWork { get; }

        public RepositoryTestsSetup()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("InMemory");
            var context = new ApplicationDbContext(builder.Options);
            UnitOfWork = new UnitOfWork(context);
        }
    }
}
