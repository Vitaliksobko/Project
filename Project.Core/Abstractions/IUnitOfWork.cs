namespace Project.Core.Abstractions;

public interface IUnitOfWork
{
    IUserRepository User { get; }
    
    Task SaveAsync();
}