namespace TaskHub.Core.Abstractions;

public interface IUnitOfWork
{
    IUserRepository User { get; }
    IBoardRepository Board { get; }
    IAttachmentRepository Attachment { get; }
    IProjectRepository Project { get; }
    ICommentRepository Comment { get; }
    IColumnRepository Column { get; }
    ITaskItemRepository TaskItem { get; }
    INotificationRepository Notification { get; }
    IProjectMemberRepository ProjectMember { get; }
    
    Task SaveAsync();
}