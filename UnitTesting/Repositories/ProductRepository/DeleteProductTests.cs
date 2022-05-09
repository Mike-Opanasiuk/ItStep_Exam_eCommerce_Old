using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Repositories.ProductRepository
{
    internal class DeleteProductTests : RepositoryTestsSetup
    {
        private readonly Guid productId = Guid.NewGuid();

        [SetUp]
        public override async Task Setup()
        {
            await base.Setup();

            await Context.Products.AddAsync(new()
            {
                Id = productId,
                Name = "Banana"
            });

            await Context.SaveChangesAsync();
        }

        [Test]
        public async Task DeleteProductAsync_DeletesProduct()
        {
            // arrange
            var initialCount = await UnitOfWork.ProductRepository.GetAll().CountAsync();

            // act
            await UnitOfWork.ProductRepository.DeleteAsync(productId);
            var actualCount = await UnitOfWork.ProductRepository.GetAll().CountAsync();

            // assert
            Assert.AreEqual(initialCount -1, actualCount, "Doesn`t delete product");
        }

        [Test]
        public async Task DeleteProductAsync_DeletesCorrectProduct()
        {
            // arrange

            // act
            await UnitOfWork.ProductRepository.DeleteAsync(productId);
            var product = await UnitOfWork.ProductRepository.FindAsync(productId);

            // assert
            Assert.AreEqual(product.Id, productId, "Deletes wrong product");
        }
    }
}
