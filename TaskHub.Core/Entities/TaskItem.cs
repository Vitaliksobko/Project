namespace TaskHub.Core.Entities;

public class TaskItem
{
    public Guid Id { get; set; }
    public Guid ColumnId { get; set; }

    public string Title { get; set; } = default!;
    public string? Description { get; set; }
    public string Priority { get; set; } = "Medium"; // Low/Medium/High
    public string Status { get; set; } = "Active";  // Active/Completed/Archived

    public DateTime? Deadline { get; set; }

    public Guid? AssignedToId { get; set; }
    public Guid CreatedById { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    // Navigation
    public Column Column { get; set; } = default!;
    public User? AssignedTo { get; set; }
    public User CreatedBy { get; set; } = default!;
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    public ICollection<Attachment> Attachments { get; set; } = new List<Attachment>();
}