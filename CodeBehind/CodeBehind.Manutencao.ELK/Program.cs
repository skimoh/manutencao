using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Logging.AddSerilog();

var app = builder.Build();

var url = app.Configuration["ElasticConfiguration:Uri"];
Log.Logger = new LoggerConfiguration()
    .Enrich.FromLogContext()
    .WriteTo.Elasticsearch(new Serilog.Sinks.Elasticsearch.ElasticsearchSinkOptions(new Uri(url))
    {        
       AutoRegisterTemplate = true,
       IndexFormat = $"codebehind-{DateTime.UtcNow:yyyy.MM.dd}",
    })
    .CreateLogger();



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
