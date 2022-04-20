using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStep_Exam_eCommerce.Core.Entities
{
    [NotMapped]
    public sealed class OrderStatuses : SmartEnum<OrderStatuses>
    {
        public readonly static OrderStatuses PENDING = new OrderStatuses("PENDING", 0);
        public readonly static OrderStatuses IN_TRANSIT = new OrderStatuses("IN_TRANSIT", 1);
        public readonly static OrderStatuses DELIVERED = new OrderStatuses("DELIVERED", 2);
        public readonly static OrderStatuses CANCELED = new OrderStatuses("CANCELED", 3);
        public readonly static OrderStatuses FAILED = new OrderStatuses("FAILED", 4);

        public OrderStatuses(string name, int value) 
            : base(name, value)
        {
            
        }
    }
}
