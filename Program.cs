using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NLog;

using NLog.Web;
using Serilog;
using sga_stif.Filtros;
using sga_stif.Mapeamento;
using sga_stif.Models;


var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog();
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);
});

// Add services to the container.
builder.Services.AddControllersWithViews(config =>
{
    config.Filters.Add(new SessaoFiltro());
    // config.Filters.Add(new LogFiltro());
    config.Filters.Add(typeof(LogFiltro));
});

builder.Services.AddDbContext<ContextoBaseDados>();
//builder.Services.AddEntityFrameworkSqlite().AddDbContext<ContextoBaseDados>();
//builder.Services.AddEntityFrameworkSq().AddDbContext<ContextoBaseDados>();

// Auto Mapper Configurations
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new PerfiDeMapeamento());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);


builder.Services.AddNotyf(config => { config.DurationInSeconds = 10; config.IsDismissable = true; config.Position = NotyfPosition.BottomCenter; });

//builder.Services.AddBreadcrumbs(GetType().Assembly);
// builder.Services.AddBreadcrumbs(args);

var app = builder.Build();

app.Use(async (ctx, next) =>
{
    await next();

    if (ctx.Response.StatusCode == 404 && !ctx.Response.HasStarted)
    {
        //Re-execute the request so the user gets the error page
        var originalPath = ctx.Request.Path.Value;
        ctx.Items["originalPath"] = originalPath;
        //ctx.Request.Path = "/Home/404";
         ctx.Request.Path = "/error/404";
        await next();
    }
});

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseNotyf();

//localizacao para PT
// var supportedCultures = new[] { "pt-PT", "pt" };
// var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(supportedCultures[0])
//     .AddSupportedCultures(supportedCultures)
//     .AddSupportedUICultures(supportedCultures);

// app.UseRequestLocalization(localizationOptions);

app.UseSession();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();