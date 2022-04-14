using ItStep_Exam_eCommerce.Core.Entities.Abstract;

namespace ItStep_Exam_eCommerce.Core.Entities
{
    public class OrderItemEntity : BaseEntity
    {
        // props
        public int CountOfProducts { get; set; }
        public decimal PurchasePrice { get; set; }
        public OrderStatuses OrderStatus { get; set; }

        // nav props
        public virtual OrderEntity Order { get; set; }
        public virtual ProductEntity Product { get; set; }
    }
}