using ItStep_Exam_eCommerce.Core.Entities.Abstract;

namespace ItStep_Exam_eCommerce.Core.Entities
{
    public class OrderEntity : BaseEntity
    {
        // props
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public OrderStatuses OrderStatus { get; set; }

        // nav props
        public virtual AppUser Buyer { get; set; }
        public virtual ICollection<OrderItemEntity> OrderItems { get; set; }

        // init
        public OrderEntity()
        {
            OrderItems = new HashSet<OrderItemEntity>();
        }
    }
}