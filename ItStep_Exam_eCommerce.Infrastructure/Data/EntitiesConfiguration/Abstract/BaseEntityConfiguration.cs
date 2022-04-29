using ItStep_Exam_eCommerce.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItStep_Exam_eCommerce.Infrastructure.Data.EntitiesConfiguration.Abstract
{
    internal abstract class BaseEntityConfiguration<TEntity>
        : IEntityTypeConfiguration<TEntity> where TEntity
        : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(u => u.CreatedAt).HasDefaultValueSql("getutcdate()").ValueGeneratedOnAdd();
            builder.Property(u => u.UpdatedAt).HasDefaultValueSql("getutcdate()").ValueGeneratedOnAddOrUpdate();
        }
    }
}
