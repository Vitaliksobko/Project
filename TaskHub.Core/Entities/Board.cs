namespace TaskHub.Core.Entities;

public class Board
{
    public Guid Id { get; set; }
    public Guid ProjectId { get; set; }

    public string Name { get; set; } = default!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public Project Project { get; set; } = default!;
    public ICollection<Column> Columns { get; set; } = new List<Column>();
}