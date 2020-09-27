using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuestRooms.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace QuestRooms
{
    public class Startup
    {
        private IConfiguration Configuration { get; set; }

        public Startup(IConfiguration config)
        {
            Configuration = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<RoomsDbContext>(opts =>
            {
                opts.UseSqlServer(Configuration["ConnectionStrings:QuestRoomsConnection"]);
            });
            //services.AddScoped<IRoomsRepository, TemplateRoomsRepository>();
            services.AddScoped<IRoomsRepository, EFRoomsRepository>();
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(
                Configuration["ConnectionStrings:IdentityConnection"]));
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppIdentityDbContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsProduction())
            {
                app.UseExceptionHandler("/error");
            } 
            else 
            { 
                app.UseDeveloperExceptionPage(); 
                app.UseStatusCodePages();
            }
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("pagination", "Rooms/Page{roomPage::regex(^[1-9]\\d*$)=1}",
                    new { Controller = "Home", action = "Index" });
                endpoints.MapControllerRoute("roominfo", "Room{QuestId}",
                    new { Controller = "Home", action = "Room" });
                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/admin/{*catchall}", "/Admin/Index");
            });
            SeedData.EnsurePopulated(app);
            IdentitySeedData.EnsurePopulated(app);
        }
    }
}
