using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Repositories.Base;

namespace UnitTesting.Repositories.ProductRepository
{
    [TestFixture]
    internal class GetProductsTests : ProductRepositoryTestsSetup
    {
        private readonly int initialCount = 5;
        [OneTimeSetUp]
        public override async Task Setup()
        {
            await base.Setup();

            for (int i = 0; i < initialCount; i++)
            {
                await Context.Products.AddAsync(new() { Name = $"Banana_{i}", Category = category });
            }

            await Context.SaveChangesAsync();
        }

        [Test]
        public async Task GetAllProductsAsync_ReturnsAllProducts()
        {
            // arrange
            var allProductsCount = initialCount;

            // act
            var actualCount = await UnitOfWork.ProductRepository.GetAll().CountAsync();

            // assert
            Assert.AreEqual(allProductsCount, actualCount);
        }

        [Test]
        public void GetAllProducts_ReturnsNotNull()
        {
            // arrange

            // act
            var products = UnitOfWork.ProductRepository.GetAll();

            // assert
            Assert.NotNull(products);
        }
    }
}
