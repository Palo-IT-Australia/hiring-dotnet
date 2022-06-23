using Microsoft.EntityFrameworkCore;
using Wallboard;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Wallboard.Configuration;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.Configure<PostCensorOptions>(builder.Configuration.GetSection("PostCensorOptions"));
builder.Services.AddPooledDbContextFactory<WallboardContext>((options) =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DbConnectionString"));
});

var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("default", "{controller}/{action=Index}/{id?}");
});
app.UseSpa(spa =>
{
    spa.Options.SourcePath = "./ClientApp";
    if (builder.Environment.IsDevelopment())
    {
        spa.UseReactDevelopmentServer(npmScript: "start");
    }
});
app.Run();