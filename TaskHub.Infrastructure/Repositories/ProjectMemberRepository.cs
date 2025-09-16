using TaskHub.Core.Abstractions;
using TaskHub.Core.Entities;
using TaskHub.Infrastructure.Data;

namespace TaskHub.Infrastructure.Repositories;

public class ProjectMemberRepository(ProjectDbContext context)
    : BaseRepository<ProjectMember>(context), IProjectMemberRepository
{
    
}