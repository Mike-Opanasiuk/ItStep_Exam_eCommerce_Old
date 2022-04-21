using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTesting.Repository.UserRepository
{
    internal class GetUsersTests : RepositoryTestsSetup
    {
        [SetUp]
        public async Task Setup()
        {
            await UnitOfWork.UserRepository.InsertAsync(new() { PhoneNumber = "123 000 001" });
            await UnitOfWork.UserRepository.InsertAsync(new() { PhoneNumber = "123 000 002" });
            await UnitOfWork.UserRepository.InsertAsync(new() { PhoneNumber = "123 000 003" });
            await UnitOfWork.UserRepository.InsertAsync(new() { PhoneNumber = "123 000 004" });
            await UnitOfWork.UserRepository.InsertAsync(new() { PhoneNumber = "123 000 005" });

            await UnitOfWork.SaveChangesAsync();
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
