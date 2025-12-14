using AirportApp.Repositories.Contracts;
using AirportApp.Services.Contracts;
using DataBase.DataBaseStorage;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Services;

var builder = WebApplication.CreateBuilder(args);

// DbContext для базы данных
builder.Services.AddDbContext<DataBaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Хранилище рейсов
builder.Services.AddScoped<IFlightStorage, DataBaseStorage>();

// Сервис для работы с рейсами
builder.Services.AddScoped<IFlightService, FlightService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
