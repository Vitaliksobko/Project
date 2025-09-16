using TaskHub.Core.Abstractions;
using TaskHub.Core.Entities;
using TaskHub.Infrastructure.Data;

namespace TaskHub.Infrastructure.Repositories;

public class TaskItemRepository(ProjectDbContext context)
    : BaseRepository<TaskItem>(context), ITaskItemRepository
{
    
}