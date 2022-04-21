using ItStep_Exam_eCommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace UnitTesting.Repository.UserRepository
{
    [TestFixture]
    internal class UpdateUserTests : RepositoryTestsSetup
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
        public async Task UpdateUserTest()
        {
            // Prepare data
            int initialCount = await UnitOfWork.UserRepository.GetAll().CountAsync();
            var phone = "123 456 789";
            var user = await UnitOfWork.UserRepository.FindAsync(UserId);

            user.PhoneNumber = phone;

            // Acting
            var result = UnitOfWork.UserRepository.Update(user);
            await UnitOfWork.SaveChangesAsync();

            // Testing
            int realCount = await UnitOfWork.UserRepository.GetAll().CountAsync();

            if (initialCount == realCount)
            {
                Assert.Fail("Something went wrong. User was insert on update");
            }

            if (result.PhoneNumber != phone)
            {
                Assert.Fail("Phone number was not updated");
            }

            Assert.Pass();
        }
    }
}
