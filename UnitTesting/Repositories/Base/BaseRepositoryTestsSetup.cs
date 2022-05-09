using ItStep_Exam_eCommerce.Infrastructure.Data;
using ItStep_Exam_eCommerce.Infrastructure.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace UnitTesting.Repositories.Base
{
    public class BaseRepositoryTestsSetup
    {
        protected IUnitOfWork UnitOfWork { get; }
        protected ApplicationDbContext Context { get; }

        public BaseRepositoryTestsSetup()
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
