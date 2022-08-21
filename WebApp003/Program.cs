using Microsoft.EntityFrameworkCore;
using WebApp003;


var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    config.AddJsonFile("appsettings.json");
});

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<WebApp003DbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("WebApp003ConnectionString")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
