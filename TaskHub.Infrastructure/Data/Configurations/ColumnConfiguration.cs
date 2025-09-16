using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskHub.Core.Entities;

namespace TaskHub.Infrastructure.Data.Configurations;

public class ColumnConfiguration : IEntityTypeConfiguration<Column>
{
    public void Configure(EntityTypeBuilder<Column> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasOne(c => c.Board)
            .WithMany(b => b.Columns)
            .HasForeignKey(c => c.BoardId);

        builder.HasMany(c => c.Tasks)
            .WithOne(t => t.Column)
            .HasForeignKey(t => t.ColumnId);
    }
}