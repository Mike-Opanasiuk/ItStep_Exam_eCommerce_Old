using ItStep_Exam_eCommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Repository.UserRepository
{
    [TestFixture]
    internal class FindUserTests : RepositoryTestsSetup
    {
        private readonly Guid UserId = Guid.NewGuid();
        private readonly string Phone = "093 456 321";

        [SetUp]
        public async Task Setup()
        {
            await UnitOfWork.UserRepository.InsertAsync(new () { PhoneNumber = "000 000 001" });
            await UnitOfWork.UserRepository.InsertAsync(new () { PhoneNumber = "000 000 002" });
            await UnitOfWork.UserRepository.InsertAsync(new () { Id = UserId, PhoneNumber = Phone });
            await UnitOfWork.UserRepository.InsertAsync(new() { PhoneNumber = "000 000 003" });
            await UnitOfWork.UserRepository.InsertAsync(new() { PhoneNumber = "000 000 004" });

            await UnitOfWork.SaveChangesAsync();
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
