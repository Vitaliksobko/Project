using FluentResults;
using Project.Application.Models;
using Project.Core.Dtos;

namespace Project.Application.Abstractions;

public interface IAuthorizationService
{
    Task<Result<TokenApiModel>> Login(LoginDto loginDto);
    Task<Result<TokenApiModel>> Registration(RegistrationDto registrationDto); 
}