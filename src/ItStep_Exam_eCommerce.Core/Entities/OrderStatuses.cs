using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStep_Exam_eCommerce.Core.Entities
{
    [NotMapped()]
    public class OrderStatuses
    {
        public const string PENDING = "Pending";
        public const string IN_TRANSIT = "In transit";
        public const string DELIVERED = "Delivered";
        public const string CANCELED = "Canceled";
        public const string FAILED = "Failed";
    }
}
