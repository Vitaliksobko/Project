using TaskHub.Core.Abstractions;
using TaskHub.Core.Entities;
using TaskHub.Infrastructure.Data;

namespace TaskHub.Infrastructure.Repositories;

public class ProjectRepository(ProjectDbContext context)
    : BaseRepository<Project>(context), IProjectRepository
{
    
}