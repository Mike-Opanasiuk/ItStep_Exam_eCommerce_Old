using ItStep_Exam_eCommerce.Core.Entities;
using ItStep_Exam_eCommerce.Core.EntitiesConfiguration.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStep_Exam_eCommerce.Core.EntitiesConfiguration
{
    internal class FeedbackEntityConfiguration : BaseEntityConfiguration<FeedbackEntity>
    {
        public override void Configure(EntityTypeBuilder<FeedbackEntity> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Message).HasMaxLength(512);

            builder.HasOne(f => f.Owner).WithMany(u => u.Feedbacks);
            builder.HasOne(f => f.Product).WithMany(p => p.Feedbacks).HasForeignKey(f => f.ProductId);
        }
    }
}
