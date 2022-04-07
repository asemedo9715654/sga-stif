using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using AutoMapper;
using NLog;
using NLog.Web;
using sga_stif.Filtros;
using sga_stif.Mapeamento;
using sga_stif.Models;


// using NLog;
// using NLog.Web;


var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Debug("init main");

// try
// {
var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();



builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(5);
});


builder.Services.AddControllers(config =>
{
    config.Filters.Add(new SessaoFiltro());
});


// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddDbContext<ContextoBaseDados>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddEntityFrameworkSqlite().AddDbContext<ContextoBaseDados>();


// Auto Mapper Configurations
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new PerfiDeMapeamento());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);


builder.Services.AddNotyf(config => { config.DurationInSeconds = 10; config.IsDismissable = true; config.Position = NotyfPosition.BottomCenter; });



//NLog: Setup NLog for Dependency injection
builder.Logging.ClearProviders();
builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
///builder.Host.UseNLog();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseNotyf();


app.Use(async (ctx, next) =>
{
    await next();

    if (ctx.Response.StatusCode == 404 && !ctx.Response.HasStarted)
    {
            //Re-execute the request so the user gets the error page
        string originalPath = ctx.Request.Path.Value;
        ctx.Items["originalPath"] = originalPath;
        ctx.Request.Path = "/Home/404";
        await next();
    }
});




app.UseSession();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();


// }
// catch (Exception exception)
// {
//     // NLog: catch setup errors
//     logger.Error(exception, "Programa Parraou por causa de uma excepcao");
//     throw;
// }
// finally
// {
//     // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
//     NLog.LogManager.Shutdown();
// }
