using TaskHub.Core.Abstractions;
using TaskHub.Core.Entities;
using TaskHub.Infrastructure.Data;

namespace TaskHub.Infrastructure.Repositories;

public class CommentRepository(ProjectDbContext context)
    : BaseRepository<Comment>(context), ICommentRepository
{
    
}