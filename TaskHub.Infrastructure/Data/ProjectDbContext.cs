using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using TaskHub.Core.Entities;

namespace TaskHub.Infrastructure.Data;

public class ProjectDbContext : IdentityDbContext<User, Role, Guid>
{
    public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Project> Projects { get; set; } = default!;
    
    public DbSet<ProjectMember> ProjectMembers { get; set; } = default!;
    
    public DbSet<Board> Boards { get; set; } = default!;
    
    public DbSet<Column> Columns { get; set; } = default!;
    
    public DbSet<TaskItem> TaskItems { get; set; } = default!;
    
    public DbSet<Comment> Comments { get; set; } = default!;
    
    public DbSet<Attachment> Attachments { get; set; } = default!;
    
    public DbSet<Notification> Notifications { get; set; } = default!;
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProjectDbContext).Assembly);
        
        base.OnModelCreating(modelBuilder);
        
        var userRoleId = new Guid("00000000-0000-0000-0000-000000000001");
        var adminRoleId = new Guid("00000000-0000-0000-0000-000000000002");
    
        modelBuilder.Entity<Role>()
            .HasData(
                new Role()
                {
                    Id = userRoleId,
                    Name = "User",
                    NormalizedName = "USER"
                },
                new Role()
                {
                    Id = adminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                });
    }
}