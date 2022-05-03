using ItStep_Exam_eCommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ItStep_Exam_eCommerce.Infrastructure.Data.EntitiesConfiguration
{
    internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(u => u.PhoneNumber).IsUnique();
            builder.Property(u => u.PhoneNumber).IsRequired().HasMaxLength(32);

            builder.Property(u => u.Email).HasMaxLength(64);
            builder.Property(u => u.Name).HasMaxLength(64);
            builder.Property(u => u.Surname).HasMaxLength(64);

            builder.Property(u => u.CreatedAt).HasDefaultValueSql("getutcdate()").ValueGeneratedOnAdd();
            builder.Property(u => u.UpdatedAt).HasDefaultValueSql("getutcdate()").ValueGeneratedOnAddOrUpdate();

            builder.HasMany(f => f.Feedbacks).WithOne(u => u.Owner).IsRequired();
            builder.HasMany(f => f.Orders).WithOne(u => u.Buyer).IsRequired();
            builder.HasMany(f => f.Carts).WithOne(u => u.Buyer).IsRequired();
        }
    }
}
