using ItStep_Exam_eCommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Repositories.UserRepository
{
    [TestFixture]
    internal class FindUserTests : RepositoryTestsSetup
    {
        private readonly Guid UserId = Guid.NewGuid();
        private readonly string Phone = "093 456 321";

        [OneTimeSetUp]
        public override async Task Setup()
        {
            await base.Setup();

            await Context.Users.AddAsync(new () { PhoneNumber = "000 000 001" });
            await Context.Users.AddAsync(new () { PhoneNumber = "000 000 002" });
            await Context.Users.AddAsync(new () { Id = UserId, PhoneNumber = Phone });
            await Context.Users.AddAsync(new() { PhoneNumber = "000 000 003" });
            await Context.Users.AddAsync(new() { PhoneNumber = "000 000 004" });

            await Context.SaveChangesAsync();
        }

        [Test]
        public async Task FindUserAsync()
        {
            // Acting
            var user = await UnitOfWork.UserRepository.FindAsync(UserId);

            // Testing
            Assert.NotNull(user, "User was not found");

            Assert.AreEqual(user.PhoneNumber, Phone, "Wrong user found");

            Assert.Pass();
        }
    }
}
