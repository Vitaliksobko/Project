namespace TaskHub.Core.Entities;

public class Notification
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }

    public string Message { get; set; } = default!;
    public string Type { get; set; } = "Info"; // TaskAssigned, DeadlineReminder, etc.
    public bool IsRead { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation
    public User User { get; set; } = default!;
}