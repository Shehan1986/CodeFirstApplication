using CodeFirstApplication.Data;
using CodeFirstApplication.Services;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var connectionString = builder.Configuration.GetConnectionString(
            "DefaultConnection") ?? throw new InvalidCastException("Default Connection not found");

            builder.Services.AddDbContext<MovieDbContext>(
                options =>
             options.UseSqlServer(connectionString)
                //options.UseSqlServer("server = (localdb)\\MSSQLLocalDB; database = MovieDb230203; trusted_connection = true; ")
                );

            builder.Services.AddScoped<IMovieService, MovieService>();

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
        }
    }
}
