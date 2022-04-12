using AspNetCoreHero.ToastNotification;
using AspNetCoreHero.ToastNotification.Extensions;
using AutoMapper;
using NLog;
using SmartBreadcrumbs;
using NLog.Web;
using sga_stif.Filtros;
using sga_stif.Mapeamento;
using sga_stif.Models;
using SmartBreadcrumbs.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();



builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(5);
});



// Add services to the container.
builder.Services.AddControllersWithViews(config =>
{
    config.Filters.Add(new SessaoFiltro());
});

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

// builder.Services.AddBreadcrumbs(assembly: GetType().Assembly);
// builder.Services.AddBreadcrumbs(args);



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



