using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using movtech.Domain.Services;
using movtech.Infra.Context;
using movtech.Infra.Repository;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.Swagger;

namespace movtech.API
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

            services.AddDbContext<MovtechContext>(opt => opt.UseMySql(Configuration.GetConnectionString("MovTech_Mysql"))); // MYSQL

            #region DI            

            // Service  
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
            services.AddScoped<IVehicleService, VehicleService>();
            services.AddScoped<IFipeAPIService, FipeAPIService>();
            services.AddScoped<IDriverService, DriverService>();
            services.AddScoped<IEntranceAndExitService, EntranceAndExitService>();
            services.AddScoped<IRefuelService, RefuelService>();
            services.AddScoped<IGasStationService, GasStationService>();
            services.AddScoped<ITrafficTicketService, TrafficTicketService>();

            //Repository
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<IDriverRepository, DriverRepository>();
            services.AddScoped<IEntranceAndExitRepository, EntranceAndExitRepository>();
            services.AddScoped<IRefuelRepository, RefuelRepository>();
            services.AddScoped<IGasStationRepository, GasStationRepository>();
            services.AddScoped<ITrafficTicketRepository, TrafficTicketRepository>();

            #endregion

            //Swagger
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "Movtech API",
                        Version = "v1",
                        Description = "API de Gerenciamento de frotas",
                        Contact = new Contact
                        {
                            Name = "Michael Willy",
                            Url = "https://github.com/codewilly"
                        }
                    });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);
            });

            services.AddHttpClient("FipeApi", c =>
            {
                c.BaseAddress = new Uri(Configuration.GetValue<string>("FipeApi:UrlBase"));
                c.DefaultRequestHeaders.Add("Accept", "application/json");
            });
                       
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1).AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.RoutePrefix = "swagger";
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MOVTech API");

            });


            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
