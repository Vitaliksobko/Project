using TaskHub.Core.Abstractions;
using TaskHub.Core.Entities;
using TaskHub.Infrastructure.Data;

namespace TaskHub.Infrastructure.Repositories;

public class BoardRepository(ProjectDbContext context)
    : BaseRepository<Board>(context), IBoardRepository
{
    
}