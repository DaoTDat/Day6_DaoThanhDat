using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Day6_DaoThanhDat.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Day6_DaoThanhDatContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Day6_DaoThanhDatContext") ?? throw new InvalidOperationException("Connection string 'Day6_DaoThanhDatContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
