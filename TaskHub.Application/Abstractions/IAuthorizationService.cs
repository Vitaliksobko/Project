using FluentResults;
using TaskHub.Core.Dtos;
using TaskHub.Application.Models;

namespace TaskHub.Application.Abstractions;

public interface IAuthorizationService
{
    Task<Result<TokenApiModel>> Login(LoginDto loginDto);
    Task<Result<TokenApiModel>> Registration(RegistrationDto registrationDto); 
}