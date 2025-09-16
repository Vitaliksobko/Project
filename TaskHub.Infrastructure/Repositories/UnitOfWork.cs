using TaskHub.Core.Abstractions;
using TaskHub.Infrastructure.Data;

namespace TaskHub.Infrastructure.Repositories;

public class UnitOfWork(
    ProjectDbContext context,
   
    Lazy<IUserRepository> userRepository,
    Lazy<INotificationRepository> notificationRepository,
    Lazy<IAttachmentRepository> attachmentRepository,
    Lazy<IBoardRepository> boardRepository,
    Lazy<IColumnRepository> columnRepository,
    Lazy<ICommentRepository> commentRepository,
    Lazy<IProjectRepository> projectRepository,
    Lazy<IProjectMemberRepository> projectMemberRepository,
    Lazy<ITaskItemRepository> taskItemRepository) : IUnitOfWork
{
    

    public IUserRepository User => userRepository.Value;
    public INotificationRepository Notification => notificationRepository.Value;
    public IAttachmentRepository Attachment => attachmentRepository.Value;
    public IBoardRepository Board => boardRepository.Value;
    public IColumnRepository Column => columnRepository.Value;
    public ICommentRepository Comment => commentRepository.Value;
    public IProjectRepository Project => projectRepository.Value;
    public IProjectMemberRepository ProjectMember => projectMemberRepository.Value;
    public ITaskItemRepository TaskItem => taskItemRepository.Value;
    
    public async Task SaveAsync() => await  context.SaveChangesAsync();
}