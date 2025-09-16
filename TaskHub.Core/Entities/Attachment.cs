namespace TaskHub.Core.Entities;

public class Attachment
{
    public Guid Id { get; set; }
    public Guid TaskItemId { get; set; }
    public Guid UploadedById { get; set; }

    public string FileName { get; set; } = default!;
    public string FileUrl { get; set; } = default!;
    public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

    // Navigation
    public TaskItem TaskItem { get; set; } = default!;
    public User UploadedBy { get; set; } = default!;
}