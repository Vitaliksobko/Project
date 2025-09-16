namespace TaskHub.Core.Entities;

public class ProjectMember
{
    public Guid Id { get; set; }

    public Guid ProjectId { get; set; }
    public Guid UserId { get; set; }

    public string RoleInProject { get; set; } = "Member";

    // Navigation
    public Project Project { get; set; } = default!;
    public User User { get; set; } = default!;
}