using ItStep_Exam_eCommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;
using UnitTesting.Repositories.Base;

namespace UnitTesting.Repositories.UserRepository
{
    [TestFixture]
    internal class InsertUserTests : BaseRepositoryTestsSetup
    {
        private const string userPhoneNumber = "093 456 678";

        [OneTimeSetUp]
        public override async Task Setup()
        {
            await base.Setup();

            await Context.Users.AddAsync(new AppUser { PhoneNumber = userPhoneNumber });

            await Context.SaveChangesAsync();
        }

        [Test]
        public async Task InsertUser()
        {
            // Prepare data
            int initialCount = await UnitOfWork.UserRepository.GetAll().CountAsync();
            var user = new AppUser { PhoneNumber = "093 456 789" };

            // Acting
            try
            {
                await Context.Users.AddAsync(user);
                await Context.SaveChangesAsync();
            }
            catch (Exception)
            {
                Assert.Fail("User was not added");
            }

            var realCount = await UnitOfWork.UserRepository.GetAll().CountAsync();

            // Testing
            if (initialCount == realCount)
            {
                Assert.Fail("User was not added");
            }

            if (user.CreatedAt > DateTime.UtcNow)
            {
                Assert.Fail("User.CreatedAt set incorectly");
            }

            if (user.UpdatedAt > DateTime.UtcNow)
            {
                Assert.Fail("User.UpdatedAt set incorectly");
            }

            Assert.Pass();
        }

        [Test]
        //[ExpectedException(typeof(DbUpdateException))]
        public async Task InsertUserWithSamePhone()
        {
            // Prepare data
            Assert.Pass(userPhoneNumber);
            int initialCount = await UnitOfWork.UserRepository.GetAll().CountAsync();
            var user = new AppUser { PhoneNumber = userPhoneNumber };
            // Acting
            try
            {
                Assert.Pass(user.PhoneNumber);
                await UnitOfWork.UserRepository.InsertAsync(user);
                await UnitOfWork.SaveChangesAsync();
            }
            catch
            {
                Assert.Pass();
            }

            // Testing
            var realCount = await UnitOfWork.UserRepository.GetAll().CountAsync();

            if (initialCount < realCount)
            {
                Assert.Fail("User.Phone must be unique");
            }

            //var usersWithTheSamePhone = UnitOfWork.UserRepository.GetAll().Where(u => u.PhoneNumber == userPhoneNumber);

            //if(usersWithTheSamePhone.Count() == 2)
            //        Assert.Fail("User.Phone must be unique");

            Assert.Pass();
        }

        [Test]
        public async Task InsertUserWithoutNumber()
        {
            // Prepare data
            var initialCount = await UnitOfWork.UserRepository.GetAll().CountAsync();
            var user = new AppUser();

            // Acting
            try
            {
                await UnitOfWork.UserRepository.InsertAsync(user);
                await UnitOfWork.SaveChangesAsync();
            }
            catch
            {
                Assert.Pass();
            }

            var realCount = await UnitOfWork.UserRepository.GetAll().CountAsync();

            // Testing
            if (initialCount == realCount)
            {
                Assert.Pass();
            }

            Assert.Fail("User must contains a phone number");
        }
    }
}
