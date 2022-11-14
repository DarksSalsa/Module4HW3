using ITCompany.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITCompany.EntityConfigs
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(p => p.ProjectId);
            builder.Property(p => p.ProjectId).HasColumnName("ProjectId").ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasColumnName("Name").HasMaxLength(50);
            builder.Property(p => p.Budget).IsRequired().HasColumnName("Budget");
            builder.Property(p => p.StartedDate).IsRequired().HasColumnName("StartedDate").HasMaxLength(7);
        }
    }
}
