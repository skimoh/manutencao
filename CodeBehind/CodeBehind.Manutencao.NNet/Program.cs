using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// NLog: Setup NLog for Dependency injection
builder.Logging.ClearProviders();
builder.Host.UseNLog();

//https://nlog-project.org/config/

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
