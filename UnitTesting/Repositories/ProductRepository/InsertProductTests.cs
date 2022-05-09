using ItStep_Exam_eCommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Repositories.ProductRepository
{
    [TestFixture]
    internal class InsertProductTests : RepositoryTestsSetup
    {
        // overriding to set [OneTimeSetUp]
        [OneTimeSetUp]
        public override async Task Setup()
        {
            await base.Setup();
        }

        [Test]
        public async Task InsertProductAsync_InsertsProduct()
        {
            // arrange
            int initialCount = await UnitOfWork.ProductRepository.GetAll().CountAsync();
            var product = new ProductEntity { Name = "Laptop" };

            // act
            try
            {
                await UnitOfWork.ProductRepository.InsertAsync(product);
                await UnitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                Assert.Fail("Product wasn`t added");
            }
            var actualCount = await UnitOfWork.ProductRepository.GetAll().CountAsync();

            // assert
            Assert.AreEqual(initialCount + 1, actualCount);
        }

        [Test]
        public async Task InsertProductAsync_InsertsProductWithCorrectData()
        {
            // arrange
            var product = new ProductEntity { Name = "Laptop" };

            // act
            await UnitOfWork.ProductRepository.InsertAsync(product);
            await UnitOfWork.SaveChangesAsync();

            // assert
            if (product.CreatedAt == DateTime.MinValue || product.CreatedAt > DateTime.UtcNow)
            {
                Assert.Fail("Product.CreatedAt set incorrectly");
            }

            if (product.UpdatedAt == DateTime.MinValue || product.UpdatedAt > DateTime.UtcNow)
            {
                Assert.Fail("Product.UpdatedAt set incorrectly");
            }
        }

    }
}
