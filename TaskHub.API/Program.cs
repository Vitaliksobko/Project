
using Microsoft.EntityFrameworkCore;
using TaskHub.API;
using TaskHub.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

var app = builder.ConfigureService().ConfigurePipeline();

await app.RunAsync();