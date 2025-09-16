using TaskHub.Core.Abstractions;
using TaskHub.Core.Entities;
using TaskHub.Infrastructure.Data;

namespace TaskHub.Infrastructure.Repositories;

public class ColumnRepository(ProjectDbContext context)
    : BaseRepository<Column>(context), IColumnRepository
{
    
}