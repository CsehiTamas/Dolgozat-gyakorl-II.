using Microsoft.EntityFrameworkCore;
using Dolgozat_gyakorló_II_.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Adatbázis kapcsolat beállítása
builder.Services.AddDbContext<BlogDbContext>(options =>
    options.UseMySql("server=localhost;database=blog_db;user=root;password=",
                     new MySqlServerVersion(new Version(8, 0, 21))));

// Szolgáltatások regisztrálása
builder.Services.AddControllers();

var app = builder.Build();

// Middleware konfigurálása
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.UseAuthorization();

app.MapControllers();

app.Run();
