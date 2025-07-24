namespace Project.Core.Dtos;

public class LoginDto
{
    public string UserName { get; set; } = null!;
    
    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}