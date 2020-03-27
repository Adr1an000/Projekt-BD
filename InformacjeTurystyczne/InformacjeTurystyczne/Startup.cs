using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InformacjeTurystyczne.IdentityPolicy;
using InformacjeTurystyczne.Models;
using InformacjeTurystyczne.Models.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace InformacjeTurystyczne
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration; // odczytujemy konfiguracje przez klas� Program.cs
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.Configure<CookieAuthenticationOptions>(options =>
            {
                options.LoginPath = new PathString("/Account/Login");
                options.AccessDeniedPath = new PathString("/Account/AccessDenied");

            });



            // musimy zarejestrowa� w kolekcji us�ug, �e b�dziemy korzysta� z EF Core
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            // rejestrowanie naszego contextu i deklaracja, �e chcemy u�ywa� SQL Server
            // jak nie dzia�a to w konsoli menad�era pakiet�w wklepujemy PM > Install-Package Microsoft.EntityFrameworkCore.SqlServer
            // potrzebujemy ci�gu po��czenia by po��czy� si� z rzeczywist� baz� danych (connection string), jest on w appsettings.json
            // p�niej robimy co� w stulu
            // services.AddTransient<ISchroniskoRepository, SchroniskoRepository>();


            services.AddAuthentication().AddGoogle(options =>
            {
                options.ClientId = "278465396718-e4gkbb2to6lmjn5lq85j2m3d2oukr48k.apps.googleusercontent.com";
                options.ClientSecret = "kZwtCzF48bQ0ytZPckBk3yCJ";
            });

            services.AddTransient<ICategoryRepository, CategoryRepository>();

            services.AddTransient<IPasswordValidator<AppUser>, CustomPasswordPolicy>();

            services.AddIdentity<AppUser, IdentityRole>(config =>
            {
                config.Password.RequiredLength = 6;
                config.Password.RequireDigit = true;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequireUppercase = false;
                config.SignIn.RequireConfirmedEmail = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseStatusCodePagesWithRedirects("/error/{0}");
            }

            app.UseStatusCodePages();

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
