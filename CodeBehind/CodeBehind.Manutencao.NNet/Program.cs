//***CODE BEHIND - BY RODOLFO.FONSECA***//
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// NLog: Setup NLog for Dependency injection
builder.Logging.ClearProviders();
builder.Host.UseNLog();

var app = builder.Build();

//https://nlog-project.org/config/

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
