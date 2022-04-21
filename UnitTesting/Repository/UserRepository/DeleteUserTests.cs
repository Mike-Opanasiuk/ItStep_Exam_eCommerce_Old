using ItStep_Exam_eCommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace UnitTesting.Repository.UserRepository
{
    [TestFixture]
    internal class DeleteUserTests : RepositoryTestsSetup
    {
        private readonly Guid UserId = Guid.NewGuid();

        [SetUp]
        public async Task Setup()
        {
            await UnitOfWork.UserRepository.InsertAsync(new AppUser
            {
                Id = UserId,
                PhoneNumber = "093 456 789"
            });

            await UnitOfWork.SaveChangesAsync();
        }

        [Test]
        public async Task DeleteUserTest()
        {
            // Prepare data
            int initialCount = await UnitOfWork.UserRepository.GetAll().CountAsync();
            var user = await UnitOfWork.UserRepository.FindAsync(UserId);

            // Acting
            await UnitOfWork.UserRepository.DeleteAsync(user.Id);
            await UnitOfWork.SaveChangesAsync();

            // Testing
            int realCount = await UnitOfWork.UserRepository.GetAll().CountAsync();

            if (initialCount == realCount)
            {
                Assert.Fail("User was not deleted");
            }

            Assert.Pass();
        }
    }
}
