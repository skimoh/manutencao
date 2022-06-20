using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Logging.ClearProviders();

var logger = new LoggerConfiguration()    
    .MinimumLevel.Information()
    .WriteTo.Console()
    .WriteTo.File("logs/arquivo.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

//Provided Sinks
//https://github.com/serilog/serilog/wiki/Provided-Sinks

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
