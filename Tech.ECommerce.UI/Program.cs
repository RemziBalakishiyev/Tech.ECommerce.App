using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tech.DataAccess.EntityFrameworks.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services
    .AddDbContext<TechContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("Local")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
