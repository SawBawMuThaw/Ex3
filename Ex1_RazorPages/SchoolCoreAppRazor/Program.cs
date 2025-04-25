using Microsoft.EntityFrameworkCore;
using SchoolCoreAppRazor.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string connString = builder.Configuration.GetConnectionString("SchoolDBConnectionString");
builder.Services.AddDbContext<SchoolContext>(options => options.UseSqlServer(connString));

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
