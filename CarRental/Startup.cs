using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using CarRental.Models;
using System.Reflection;
using MediatR;
using CarRental.Core.Common.Interfaces;

namespace CarRental
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            var connection = @"Server=MARIUSZ-PC\SQLEXPRESS;Database=Car_Rental;Trusted_Connection=True;";
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(connection));


            services.AddSingleton<IApplicationDBContext, ApplicationDBContext>();
            services.AddMediatR(typeof(GetFilterCarsListQuery).GetTypeInfo().Assembly);
            services.AddMvc();

        }


        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        //public void ConfigureServices(IServiceCollection services)

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvcWithDefaultRoute();
            //app.UseMvc(routes =>
            //{

            //});
            SeedData.EnsurePopulatedOfferName(app);
            SeedData.EnsurePopulatedPricelist(app);
            SeedData.EnsurePopulatedCarVersions(app);
            SeedData.EnsurePopulatedCars(app);
        }
    }
}
