using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStep_Exam_eCommerce.Core.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        // props
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Photo { get; set; }
        public DateTime RegisteredAt { get; set; }
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
