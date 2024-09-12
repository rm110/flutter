using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;
using VigilanceFire.Repository;

namespace VigilanceFire
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the DI container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IAdministratorRepository, AdministratorRepository>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<IAlertRepository, AlertRepository>();
            builder.Services.AddScoped<IMain_DashboardRepository, DashboardRepository>();
            builder.Services.AddScoped<ICamerasRepository, CamerasRepository>();
            builder.Services.AddScoped<IGasControllerRepository, GasControllerRepository>();
            builder.Services.AddScoped<IEvacuation_InstructionsRepository, Evacuation_InstructionsRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();


            // Routes
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Route for the Administrator
            app.MapControllerRoute(
               name: "Administrator",
               pattern: "{controller=Administrator}/{action=SignIn}/{id?}");

            // Route for the User
            app.MapControllerRoute(
                name: "User",
                pattern: "{controller=User}/{action=SignIn}/{id?}");

            // Route for the Alert
            app.MapControllerRoute(
                name: "Alert",
                pattern: "{controller=Alert}/{action=Index}/{id?}");

            // Route for the Dashboard
            app.MapControllerRoute(
                name: "Main_Dashboard",
                pattern: "{controller=Main_Dashboard}/{action=Index}/{id?}");

            // Route for the CameraControlController
            app.MapControllerRoute(
                name: "Cameras",
                pattern: "{controller=Cameras}/{action=Index}/{id?}");

            // Route for the GasControllerController
            app.MapControllerRoute(
                name: "GasController",
                pattern: "{controller=GasController}/{action=Index}/{id?}");

             // Route for the EvacuationInstructions
            app.MapControllerRoute(
                name: "Evacuation_Instructions",
                pattern: "{controller=Evacuation_Instructions}/{action=Index}/{id?}");

            app.Run();

        }
    }
}
