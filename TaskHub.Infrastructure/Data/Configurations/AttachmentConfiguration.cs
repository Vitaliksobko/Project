using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskHub.Core.Entities;

namespace TaskHub.Infrastructure.Data.Configurations;

public class AttachmentConfiguration : IEntityTypeConfiguration<Attachment>
{
    public void Configure(EntityTypeBuilder<Attachment> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.FileName)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(a => a.FileUrl)
            .IsRequired()
            .HasMaxLength(500);

        builder.HasOne(a => a.TaskItem)
            .WithMany(t => t.Attachments)
            .HasForeignKey(a => a.TaskItemId);

        builder.HasOne(a => a.UploadedBy)
            .WithMany(u => u.Attachments)
            .HasForeignKey(a => a.UploadedById);
    }
}