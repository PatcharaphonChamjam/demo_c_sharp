using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MoviesAPI.Filters;
using MoviesAPI.Services;
using System;

namespace MoviesAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Data.ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(typeof(Startup)); //40.Data Tranfer Objects and AutoMapper

            services.AddTransient<IFileStorageService, InAppStorageService>(); //47.Saving Files Locally
            
            services.AddTransient<IHostedService, MoviesInTheaterService>(); //56.Background Task With Entity Framwork Core
            services.AddHttpContextAccessor(); //47.Saving Files Locally

            services.AddControllers(options =>
            {
                options.Filters.Add(typeof(MyExceptionFilter)); //31.Custom filters
            }).AddNewtonsoftJson() //49.HTTP Patch and JSON Patch
              .AddXmlDataContractSerializerFormatters(); //32.Adding XML Support

            services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Version = "V1",
                    Title = "MovieAPI",
                    Description = "This is a Web API for Movies operations",
                    TermsOfService = new Uri("https://github.com/PatcharaphonChamjam/demo_c_sharp"),
                    License = new Microsoft.OpenApi.Models.OpenApiLicense()
                    {
                        Name = "MIT"
                    },
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact()
                    {
                        Name = "Patcharaphon Chamjam",
                        Email = "patcharaphon.chamjam@gmail.com",
                    }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("/swagger/v1/swagger.json", "MoviesAPI");
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles(); //47.Saving Files Locally

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}