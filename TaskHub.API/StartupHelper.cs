
using FluentValidation;
using TaskHub.Application;
using TaskHub.Infrastructure;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;


namespace TaskHub.API;

public static class StartupHelperExtensions
{
    public static WebApplication ConfigureService(this WebApplicationBuilder builder)
    {
        
        builder.Services.AddControllers();

        builder.Services.AddApplicationServices();
        builder.Services.AddInfrastructureServices(builder.Configuration);
        builder.Services.AddFluentValidationAutoValidation();
        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ApplicationAssemblyMarker).Assembly));
        builder.Services.AddValidatorsFromAssembly(typeof(ApplicationAssemblyMarker).Assembly);
        builder.Services.AddFluentValidationAutoValidation();
        
        
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        
        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(corsPolicyBuilder =>
            {
                corsPolicyBuilder.WithOrigins("http://localhost:4200")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
            });
        });
        
        return builder.Build();
    }

    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseCors();
        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();
        

        return app;
    }
}