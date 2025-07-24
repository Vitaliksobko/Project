using FluentResults;

namespace Project.Core.Errors;

public class EntityNotFoundError(string message) : Error(message)
{
    
}