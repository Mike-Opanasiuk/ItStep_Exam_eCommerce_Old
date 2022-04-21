using ItStep_Exam_eCommerce.Core.Entities;
using ItStep_Exam_eCommerce.Infrastructure.Data;
using ItStep_Exam_eCommerce.Infrastructure.UnitOfWork.Repositories.Abstract;
using ItStep_Exam_eCommerce.Infrastructure.UnitOfWork.Repositories.Base;

namespace ItStep_Exam_eCommerce.Infrastructure.UnitOfWork.Repositories
{
    public class UserRepository : Repository<AppUser, Guid>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context)
            : base(context)
        {

        }
    }
}
