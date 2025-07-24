
using Microsoft.EntityFrameworkCore;
using Project.API;
using Project.infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

var app = builder.ConfigureService().ConfigurePipeline();

await app.RunAsync();