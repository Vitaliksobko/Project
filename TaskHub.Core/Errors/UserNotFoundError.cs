using FluentResults;

namespace TaskHub.Core.Errors;

public class UserNotFoundError(string message) : Error(message)
{
    
}