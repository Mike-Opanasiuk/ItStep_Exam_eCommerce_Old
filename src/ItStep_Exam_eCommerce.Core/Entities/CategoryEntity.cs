using ItStep_Exam_eCommerce.Core.Entities.Abstract;

namespace ItStep_Exam_eCommerce.Core.Entities
{
    public class CategoryEntity : BaseEntity
    {
        // props
        public string Title { get; set; }
        public string Image { get; set; }
        public int? ParentId { get; set; }

        // nav props
        public virtual ICollection<ProductEntity> Products { get; set; }
        public virtual CategoryEntity Parent { get; set; }

        // init
        public CategoryEntity()
        {
            Products = new HashSet<ProductEntity>();
        }
    }
}