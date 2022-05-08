using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTesting.Repository.UserRepository
{
    [TestFixture]
    internal class GetUsersTests : RepositoryTestsSetup
    {
        [OneTimeSetUp]
        public override async Task Setup()
        {
            await base.Setup();

            await Context.Users.AddAsync(new() { PhoneNumber = "123 000 001" });
            await Context.Users.AddAsync(new() { PhoneNumber = "123 000 002" });
            await Context.Users.AddAsync(new() { PhoneNumber = "123 000 003" });
            await Context.Users.AddAsync(new() { PhoneNumber = "123 000 004" });
            await Context.Users.AddAsync(new() { PhoneNumber = "123 000 005" });

            await Context.SaveChangesAsync();
        }

        [Test]
        public void GetUsersTest()
        {
            var users = UnitOfWork.UserRepository.GetAll();

            Assert.NotNull(users, "Users null");
            Assert.NotZero(users.Count(), "Users was not found");

            Assert.Pass();
        }
    }
}
