
using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using TaskHub.Application.Abstractions;
using TaskHub.Application.Behaviours;
using TaskHub.Application.Models;
using TaskHub.Application.Services;

namespace TaskHub.Application;

public static class ApplicationServicesRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    { 
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddScoped(typeof(Lazy<>), typeof(LazyInstance<>));
        services.AddScoped<IAuthorizationService, AuthorizationService>();
        services.AddScoped<ITokenService, TokenService>();
        
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

        
        services.AddSingleton<IDictionary<string, Guid>>(new Dictionary<string, Guid>());
        
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        
        return services;
    }
}