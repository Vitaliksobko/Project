using FluentResults;

namespace Project.Core.Errors;

public class ValidationError(string message) : Error(message)
{
    
}