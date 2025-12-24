using CodeSniffs.API.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddDbContext<CodesniffsDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("dbsc")));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var port=Environment.GetEnvironmentVariable("port") ?? "10000";
app.Urls.Add($"http://0.0.0.0:{port}");
// Middleware
if (!app.Environment.IsDevelopment())
{
    // Do NOT call app.UseHttpsRedirection();
}
else
{
    app.UseHttpsRedirection();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
