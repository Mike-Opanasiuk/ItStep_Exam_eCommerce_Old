using ItStep_Exam_eCommerce.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStep_Exam_eCommerce.Core.Entities
{
    public class FeedbackEntity : BaseEntity
    {
        // props
        public string Message { get; set; }
        public int Rate { get; set; }

        // foreign keys
        public int? ProductId { get; set; }

        // nav props
        public virtual AppUser Owner { get; set; }
        public virtual ProductEntity Product { get; set; }
    }
}
