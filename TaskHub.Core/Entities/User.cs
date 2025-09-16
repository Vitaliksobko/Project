using Microsoft.AspNetCore.Identity;

namespace TaskHub.Core.Entities;

public class User : IdentityUser<Guid>
{
    public string FirstName { get; set; } = null!;

    public string SecondName { get; set; } = null!;

    public DateOnly RegistrationDate { get; set; }
    
    public string? RefreshToken { get; set; }

    public DateTime? RefreshTokenExpiration { get; set; }

    // Navigation properties
    public ICollection<ProjectMember> ProjectMemberships { get; set; } = new List<ProjectMember>();
    public ICollection<TaskItem> AssignedTasks { get; set; } = new List<TaskItem>();
    public ICollection<TaskItem> CreatedTasks { get; set; } = new List<TaskItem>();
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();
    public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
}