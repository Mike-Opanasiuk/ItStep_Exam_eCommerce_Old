using ItStep_Exam_eCommerce.Core.Entities.Abstract;

namespace ItStep_Exam_eCommerce.Core.Entities
{
    public class ProductImageEntity : BaseEntity
    {
        // props
        public string Title { get; set; }

        // nav props
        public virtual ProductEntity Product { get; set; }
    }
}