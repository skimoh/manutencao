//***CODE BEHIND - BY RODOLFO.FONSECA***//
//https://kisslog.net/Docs/SDK.install-instructions.netcore-webApp.html

using KissLog;
using KissLog.AspNetCore;
using KissLog.CloudListeners.Auth;
using KissLog.CloudListeners.RequestLogsListener;
using KissLog.Formatters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<IKLogger>((provider) => Logger.Factory.Get());

builder.Services.AddLogging(logging =>
{
    logging.AddKissLog(options =>
    {
        options.Formatter = (FormatterArgs args) =>
        {
            if (args.Exception == null)
                return args.DefaultValue;

            string exceptionStr = new ExceptionFormatter().Format(args.Exception, args.Logger);

            return string.Join(Environment.NewLine, new[] { args.DefaultValue, exceptionStr });
        };
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

var kissOrg = builder.Configuration.GetSection("KissLog.OrganizationId").Value;
var kissApp = builder.Configuration.GetSection("KissLog.ApplicationId").Value;
var kissUrl = builder.Configuration.GetSection("KissLog.ApiUrl").Value;

app.UseKissLogMiddleware(options => KissLogConfiguration.Listeners
        .Add(new RequestLogsApiListener(new Application(kissOrg, kissApp))
        {
            ApiUrl = kissUrl
        }));

app.UseRouting();

app.UseAuthorization();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


