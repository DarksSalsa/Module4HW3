using ITCompany.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITCompany.EntityConfigs
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title").HasKey(p => p.TitleId);
            builder.Property(p => p.TitleId).HasColumnName("TitleId").ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
        }
    }
}
