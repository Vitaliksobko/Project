using TaskHub.Core.Abstractions;
using TaskHub.Core.Entities;
using TaskHub.Infrastructure.Data;

namespace TaskHub.Infrastructure.Repositories;

public class NotificationRepository(ProjectDbContext context)
    : BaseRepository<Notification>(context), INotificationRepository
{
    
}