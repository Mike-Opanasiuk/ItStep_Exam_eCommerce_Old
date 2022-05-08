using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace UnitTesting.Repositories.ProductRepository
{
    [TestFixture]
    internal class FindProductTests : RepositoryTestsSetup
    {
        private readonly Guid productId = Guid.NewGuid();
        private readonly string searchName = "SearchedItem";

        [OneTimeSetUp]
        public override async Task Setup()
        {
            await base.Setup();

            await Context.Products.AddAsync(new() { Id = productId, Name = searchName });

            for (int i = 0; i < 4; i++)
            {
                await Context.Products.AddAsync(new() { Name = searchName + $"_{i}" });
            }

            await Context.SaveChangesAsync();
        }

        [Test]
        public async Task FindProductAsync_ReturnsNotNull()
        {
            // arrange

            // act
            var product = await UnitOfWork.ProductRepository.FindAsync(productId);

            // assert
            Assert.NotNull(product, "Product wasn`t found");
        }

        [Test]
        public async Task FindProductAsync_ReturnsCorrectProduct()
        {
            // arrange

            // act
            var product = await UnitOfWork.ProductRepository.FindAsync(productId);

            // assert
            Assert.AreEqual(product.Name, searchName, "Wrong product was found");
        }
    }
}
