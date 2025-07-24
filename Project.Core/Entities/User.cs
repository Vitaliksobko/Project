using Microsoft.AspNetCore.Identity;

namespace Project.Core.Entities;

public class User : IdentityUser<Guid>
{
    public string FirstName { get; set; } = null!;

    public string SecondName { get; set; } = null!;

    public DateOnly RegistrationDate { get; set; }
    
    public string? RefreshToken { get; set; }

    public DateTime? RefreshTokenExpiration { get; set; }

    
}