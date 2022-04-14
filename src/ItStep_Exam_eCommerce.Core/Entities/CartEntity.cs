using ItStep_Exam_eCommerce.Core.Entities.Abstract;

namespace ItStep_Exam_eCommerce.Core.Entities
{
    public class CartEntity : BaseEntity
    {
        // nav props
        public virtual ICollection<CartItemEntity> CartItems { get; set; }
        public virtual AppUser Buyer { get; set; }

        // init
        public CartEntity()
        {
            CartItems = new HashSet<CartItemEntity>();
        }
    }
}