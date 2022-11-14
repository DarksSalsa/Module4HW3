using ITCompany.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITCompany.EntityConfigs
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(p => p.OfficeId);
            builder.Property(p => p.OfficeId).HasColumnName("OfficeId").ValueGeneratedOnAdd();
            builder.Property(p => p.Title).HasColumnName("Title").IsRequired().HasMaxLength(100);
            builder.Property(p => p.Location).HasColumnName("Location").IsRequired().HasMaxLength(100);
        }
    }
}
