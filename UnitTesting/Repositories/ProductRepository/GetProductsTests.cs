using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Repositories.ProductRepository
{
    [TestFixture]
    internal class GetProductsTests : RepositoryTestsSetup
    {
        [OneTimeSetUp]
        public override async Task Setup()
        {
            await base.Setup();

            for (int i = 0; i < 5; i++)
            {
                await Context.Products.AddAsync(new() { Name = $"Banana_{i}" });
            }

            await Context.SaveChangesAsync();
        }

        [Test]
        public void GetProducts_ReturnsProducts()
        {
            var users = UnitOfWork.UserRepository.GetAll();

            Assert.NotNull(users, "Users null");
            Assert.NotZero(users.Count(), "Users was not found");

            Assert.Pass();
        }
    }
}
