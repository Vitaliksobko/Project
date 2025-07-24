using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Project.Core.Entities;

namespace Project.infrastructure.Data;

public class ProjectDbContext : IdentityDbContext<User, Role, Guid>
{
    
    
    public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    
        // Визначаємо статичні GUID як константи
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