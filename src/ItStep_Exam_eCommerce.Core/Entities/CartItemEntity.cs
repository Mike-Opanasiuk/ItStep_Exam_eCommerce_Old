using ItStep_Exam_eCommerce.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStep_Exam_eCommerce.Core.Entities
{
    public class CartItemEntity : BaseEntity
    {
        // props
        public int CountOfProducts { get; set; }

        // nav props
        public virtual ProductEntity Product { get; set; }
        public virtual CartEntity Cart { get; set; } 
    }
}
