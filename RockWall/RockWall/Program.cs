using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RockWall.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<RockWallContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RockWallContext") ?? throw new InvalidOperationException("Connection string 'RockWallContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error"); // loads generic exception page for the prod environemnt
    app.UseHsts();// adds HSTS header to the response
}

app.UseHttpsRedirection(); // http to https
app.UseStaticFiles();   // loads static files from wwwroot

app.UseRouting(); // decisions made for routing here

app.UseAuthorization(); //protect against unauthorized users

app.MapRazorPages(); // enables endpoint routing - razor pages

app.Run();
