using FluentResults;

namespace Project.Core.Errors;

public class UserNotFoundError(string message) : Error(message)
{
    
}