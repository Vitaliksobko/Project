using FluentValidation;
using TaskHub.Core.Dtos;

namespace TaskHub.Application.Validations.AuthValidators;

public class RegistrationValidator : AbstractValidator<RegistrationDto>
{
    public RegistrationValidator()
    {
        RuleFor(r => r.FirstName)
            .NotNull().NotEmpty().WithMessage("First name is required")
            .MaximumLength(5).WithMessage("First name must be at most 5 characters long");

        RuleFor(r => r.SecondName).NotNull().NotEmpty().WithMessage("Second name is required");;
        
        RuleFor(r => r.UserName).NotNull().NotEmpty().WithMessage("Username is required");
        
        RuleFor(r => r.Email).NotNull().NotEmpty().WithMessage("Email is required")
            .EmailAddress().WithMessage("Invalid email address");
        
        RuleFor(r => r.Password).NotNull().NotEmpty().WithMessage("Password is required")
            .MinimumLength(8).WithMessage("Password must be at least 8 characters");
    }
}