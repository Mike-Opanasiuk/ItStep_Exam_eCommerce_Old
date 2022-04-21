﻿using ItStep_Exam_eCommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace UnitTesting.Repository.UserRepository
{
    [TestFixture]
    internal class InsertUserTests : RepositoryTestsSetup
    {
        [SetUp]
        public async Task Setup()
        {
            await UnitOfWork.UserRepository.InsertAsync(new AppUser
            {
                PhoneNumber = "093 456 678"
            });

            await UnitOfWork.SaveChangesAsync();
        }

        [Test]
        public async Task InsertUser()
        {
            // Prepare data
            int initialCount = await UnitOfWork.UserRepository.GetAll().CountAsync();
            var user = new AppUser { PhoneNumber = "093 456 789" };

            // Acting
            await UnitOfWork.UserRepository.InsertAsync(user);
            await UnitOfWork.SaveChangesAsync();
            var realCount = await UnitOfWork.UserRepository.GetAll().CountAsync();

            // Testing
            if (initialCount == realCount)
            {
                Assert.Fail("User was not added");
            }

            if (user.CreatedAt < DateTime.UtcNow)
            {
                Assert.Fail("User.CreatedAt set incorectly");
            }

            if (user.UpdatedAt < DateTime.UtcNow)
            {
                Assert.Fail("User.UpdatedAt set incorectly");
            }

            Assert.Pass();
        }

        [Test]
        public async Task InsertUserWithSamePhone()
        {
            // Prepare data
            int initialCount = await UnitOfWork.UserRepository.GetAll().CountAsync();
            var user = new AppUser { PhoneNumber = "093 456 678" };

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

            // Testing
            var realCount = await UnitOfWork.UserRepository.GetAll().CountAsync();

            if (initialCount < realCount)
            {
                Assert.Fail("User.Phone mus be unique");
            }

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
