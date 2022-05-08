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
    internal class UpdateProductTests : RepositoryTestsSetup
    {
        private readonly Guid productId = Guid.NewGuid();

        [OneTimeSetUp]
        public override async Task Setup()
        {
            await base.Setup();

            await UnitOfWork.ProductRepository.InsertAsync(new ProductEntity
            {
                Id = productId,
                Name = "Banana"
            });

            await UnitOfWork.SaveChangesAsync();
        }

        [Test]
        public async Task UpdateProductAsync_ReturnsUpdatedProduct()
        {
            // arrange
            int initialCount = await UnitOfWork.ProductRepository.GetAll().CountAsync();
            var newName = "Apple";
            var product = await UnitOfWork.ProductRepository.FindAsync(productId);

            product.Name = newName;

            // act
            var result = UnitOfWork.ProductRepository.Update(product);
            await UnitOfWork.SaveChangesAsync();
            int actualCount = await UnitOfWork.UserRepository.GetAll().CountAsync();


            // assert
            Assert.AreEqual(initialCount, actualCount, "Something went wrong. Product was insert while updating");
            Assert.AreEqual(result.Name, newName, "Something went wrong. Product wasn`t updated");
        }
    }
}
