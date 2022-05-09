using ItStep_Exam_eCommerce.Infrastructure.Data;
using ItStep_Exam_eCommerce.Infrastructure.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace UnitTesting.Repositories
{
    public class RepositoryTestsSetup
    {
        protected IUnitOfWork UnitOfWork { get; }
        protected ApplicationDbContext Context { get; }

        public RepositoryTestsSetup()
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlServer(AppEnv.ConnectionStrings.CONNECTION_STRING);
            Context = new ApplicationDbContext(builder.Options);
            UnitOfWork = new UnitOfWork(Context);
        }

        public virtual async Task Setup()
        {
            await Context.Database.EnsureDeletedAsync();
            await Context.Database.EnsureCreatedAsync();
        }
    }
}
