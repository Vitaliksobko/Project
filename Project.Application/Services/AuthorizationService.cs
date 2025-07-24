using System.Security.Authentication;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using Project.Application.Abstractions;
using Project.Application.Models;
using Project.Core.Dtos;
using Project.Core.Entities;
using Project.Core.Errors;

namespace Project.Application.Services;

public class AuthorizationService(
    UserManager<User> userManager,
    SignInManager<User> signInManager,
    ITokenService tokenService) : IAuthorizationService
{
    public async Task<Result<TokenApiModel>> Login(LoginDto loginDto)
    {
        var userByUsername = await userManager.FindByNameAsync(loginDto.UserName);
        
        if (userByUsername == null) 
            return new EntityNotFoundError("No user with given username was found");
        
        if (userByUsername.Email != loginDto.Email)
            return new EntityNotFoundError("Wrong email");
        
        var result = await signInManager
            .PasswordSignInAsync(userByUsername.UserName!, loginDto.Password, false, false);

        return !result.Succeeded
            ? new ValidationError(result.ToString())
            : Result.Ok(await tokenService.GenerateToken(userByUsername, true));
    }

    public async Task<Result<TokenApiModel>> Registration(RegistrationDto registrationDto)
    {
        var user = new User()
        {
            Email = registrationDto.Email,
            FirstName = registrationDto.FirstName,
            SecondName = registrationDto.SecondName,
            UserName = registrationDto.UserName,
            RegistrationDate = DateOnly.FromDateTime(DateTime.UtcNow)
        };

        var result = await userManager.CreateAsync(user, registrationDto.Password);

        if (!result.Succeeded)
            throw new AuthenticationException(result.Errors.First().Description);

        await userManager.AddToRoleAsync(user, "Admin");
        await userManager.UpdateAsync(user);

        return Result.Ok(await tokenService.GenerateToken(user, true));
    }
}