namespace TaskHub.Core.Entities;

public class Comment
{
    public Guid Id { get; set; }
    public Guid TaskItemId { get; set; }
    public Guid UserId { get; set; }

    public string Content { get; set; } = default!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public TaskItem TaskItem { get; set; } = default!;
    public User User { get; set; } = default!;
}