using e_Tickets.Context;
using e_Tickets.Data.DataSeeding;
using e_Tickets.Repository;
using Microsoft.EntityFrameworkCore;

namespace e_Tickets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //add database service
            builder.Services.AddDbContext<ETicketsDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefualtConnectionString"));
            });

            //inject the Igenericrepositor
            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(TicketsGenericRepositry<>));

            var app = builder.Build();

            //add datasedding 
            ETicketsDbSeedding.DataSeeding(app);

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