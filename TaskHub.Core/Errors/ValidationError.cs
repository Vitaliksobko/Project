using FluentResults;

namespace TaskHub.Core.Errors;

public class ValidationError(string message) : Error(message)
{
    
}