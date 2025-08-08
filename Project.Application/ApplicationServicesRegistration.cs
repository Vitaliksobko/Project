
using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Project.Application.Abstractions;
using Project.Application.Models;
using Project.Application.Services;

namespace Project.Application;

public static class ApplicationServicesRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    { 
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddScoped(typeof(Lazy<>), typeof(LazyInstance<>));
        services.AddScoped<IAuthorizationService, AuthorizationService>();
        services.AddScoped<ITokenService, TokenService>();
        
        services.AddSingleton<IDictionary<string, Guid>>(new Dictionary<string, Guid>());
        
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        
        return services;
    }
}