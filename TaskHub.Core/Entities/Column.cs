namespace TaskHub.Core.Entities;

public class Column
{
    public Guid Id { get; set; }
    public Guid BoardId { get; set; }

    public string Name { get; set; } = default!;
    public int Order { get; set; }
    
    public Board Board { get; set; } = default!;
    public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
}