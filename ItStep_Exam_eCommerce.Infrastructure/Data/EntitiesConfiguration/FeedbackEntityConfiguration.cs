using ItStep_Exam_eCommerce.Core.Entities;
using ItStep_Exam_eCommerce.Infrastructure.Data.EntitiesConfiguration.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItStep_Exam_eCommerce.Infrastructure.Data.EntitiesConfiguration
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
