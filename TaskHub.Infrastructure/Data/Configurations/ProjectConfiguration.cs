using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskHub.Core.Entities;

namespace TaskHub.Infrastructure.Data.Configurations;

public class ProjectConfiguration : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.HasOne(p => p.CreatedBy)
            .WithMany()
            .HasForeignKey(p => p.CreatedById)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(p => p.Members)
            .WithOne(m => m.Project)
            .HasForeignKey(m => m.ProjectId);

        builder.HasMany(p => p.Boards)
            .WithOne(b => b.Project)
            .HasForeignKey(b => b.ProjectId);
    }
}