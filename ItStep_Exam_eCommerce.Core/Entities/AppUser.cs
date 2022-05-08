using ItStep_Exam_eCommerce.Core.Entities.Abstract;
using Microsoft.AspNetCore.Identity;

namespace ItStep_Exam_eCommerce.Core.Entities
{
    public class AppUser : IdentityUser<Guid>, IEntity
    {
        // props
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Photo { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // nav props
        public virtual ICollection<FeedbackEntity> Feedbacks { get; set; }
        public virtual ICollection<OrderEntity> Orders { get; set; }
        public virtual ICollection<CartEntity> Carts { get; set; }

        // init
        public AppUser()
        {
            Feedbacks = new HashSet<FeedbackEntity>();
            Orders = new HashSet<OrderEntity>();
            Carts = new HashSet<CartEntity>();
        }
    }
}
