using ITCompany.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITCompany.EntityConfigs
{
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(p => p.EmployeeProjectId);
            builder.Property(p => p.EmployeeProjectId).HasColumnName("EmployeeProjectId").ValueGeneratedOnAdd();
            builder.Property(p => p.Rate).IsRequired().HasColumnName("Rate");
            builder.Property(p => p.StartedDate).IsRequired().HasColumnName("StartedDate").HasMaxLength(7);
            builder.Property(p => p.EmployeeId).IsRequired().HasColumnName("EmployeeId");
            builder.Property(p => p.ProjectId).IsRequired().HasColumnName("ProjectId");
            builder.HasOne(p => p.Employee).WithMany(d => d.EmployeeProjects).HasForeignKey(d => d.EmployeeProjectId).OnDelete(DeleteBehavior.Cascade).IsRequired();
            builder.HasOne(p => p.Project).WithMany(d => d.EmployeeProjects).HasForeignKey(d => d.EmployeeProjectId).OnDelete(DeleteBehavior.Cascade).IsRequired();
        }
    }
}
