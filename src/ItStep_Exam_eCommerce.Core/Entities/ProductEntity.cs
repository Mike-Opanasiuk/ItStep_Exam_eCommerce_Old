using ItStep_Exam_eCommerce.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStep_Exam_eCommerce.Core.Entities
{
    public class ProductEntity : BaseEntity
    {
        // props
        public string Name { get; set; }
        public int Priority { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        // nav props
        public virtual CategoryEntity Category { get; set; }
        public virtual ICollection<ProductImageEntity> ProductImages { get; set; }
        public virtual ICollection<FeedbackEntity> Feedbacks { get; set; }
        public virtual ICollection<CartItemEntity> CartItems { get; set; }
        public virtual ICollection<OrderItemEntity> OrderItems { get; set; }

        // init
        public ProductEntity()
        {
            ProductImages = new HashSet<ProductImageEntity>();
            Feedbacks = new HashSet<FeedbackEntity>();
            CartItems = new HashSet<CartItemEntity>();
            OrderItems = new HashSet<OrderItemEntity>();
        }
    }
}
