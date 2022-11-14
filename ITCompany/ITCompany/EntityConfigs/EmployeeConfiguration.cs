using ITCompany.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ITCompany.EntityConfigs
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(p => p.EmployeeId);
            builder.Property(p => p.EmployeeId).HasColumnName("EmployeeId").ValueGeneratedOnAdd();
            builder.Property(p => p.FirstName).IsRequired().HasMaxLength(50).HasColumnName("FirstName");
            builder.Property(p => p.LastName).IsRequired().HasMaxLength(50).HasColumnName("LastName");
            builder.Property(p => p.HiredDate).IsRequired().HasColumnName("HiredDate").HasMaxLength(7);
            builder.Property(p => p.DateOfBirth).HasColumnName("DateOfBirth");
            builder.HasOne(p => p.Title).WithMany(d => d.Employees).HasForeignKey(p => p.TitleId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(p => p.Office).WithMany(d => d.Employees).HasForeignKey(p => p.OfficeId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
