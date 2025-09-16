using TaskHub.Core.Abstractions;
using TaskHub.Infrastructure.Data;

namespace TaskHub.Infrastructure.Repositories;

public class UnitOfWork(
    ProjectDbContext context,
   
    Lazy<IUserRepository> userRepository) : IUnitOfWork
{
    

    public IUserRepository User => userRepository.Value;
    
   
    public async Task SaveAsync() => await  context.SaveChangesAsync();
}