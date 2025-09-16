using FluentResults;

namespace TaskHub.Core.Errors;

public class EntityNotFoundError(string message) : Error(message)
{
    
}