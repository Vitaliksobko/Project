using TaskHub.Core.Abstractions;
using TaskHub.Core.Entities;
using TaskHub.Infrastructure.Data;

namespace TaskHub.Infrastructure.Repositories;

public class AttachmentRepository(ProjectDbContext context)
    : BaseRepository<Attachment>(context), IAttachmentRepository
{
    
}