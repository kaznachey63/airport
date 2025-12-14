using DataBase;
using Repositories;
using Repositories.Contracts;
using Services;
using Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<DataBaseContext>();
builder.Services.AddScoped<IFlightStorage, DataBaseStorage>();
builder.Services.AddScoped<IFlightService, FlightService>();

var app = builder.Build();

// ❌ НЕ вызывай EnsureCreated() здесь — он уже в конструкторе контекста!

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