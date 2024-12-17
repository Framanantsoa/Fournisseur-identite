using App.Context;
using App.Services;
using Microsoft.EntityFrameworkCore;

namespace App.Main;

public class Program
{
    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);
    // Les services
        builder.Services.AddScoped<UserService>();
    // Configuration de PostgreSQL
        builder.Services.AddDbContext<MyDbContext>(opt =>
            opt.UseNpgsql(
                builder.Configuration.GetConnectionString("Default")
            )
        );
    // Ajouter les contrôleurs
        builder.Services.AddControllers();
        builder.WebHost.UseUrls("http://0.0.0.0:5000");

        var app = builder.Build();

    // Configuration des middlewares
        if (!app.Environment.IsDevelopment())
        {
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}
