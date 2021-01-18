using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using PortNet.Data.Infrastructure;
using PortNet.Data.Migrations.INFPortDbContext;
using PortNet.Data.Migrations.INFPortObjectDbContext;
using PortNet.Data.Repositories;
using PortNet.Model.Entities.INFPort;
using PortNet.Model.Models.Authentication;
using System;
using System.Collections.Generic;
using Web.BackendServer.Extentions;
using Web.BackendServer.IdentityServer;
using Web.BackendServer.UndergroundWorks.Mapping;
using Web.BackendServer.UndergroundWorks.ReadRequest.ViewModels;
using Web.BackendServer.UndergroundWorks.Repositories;

namespace Web.BackendServer
{
    public class Startup
    {
        private readonly string KspSpecificOrigins = "KspSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //1. Setup entity framework for INFPortObjectDbContext
            services.AddDbContext<INFPortObjectDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("INFPortObjectConnection")));

            //2. Setup entity framework for INFPortDbContext
            services.AddDbContext<INFPortDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("INFPortConnection")));

            //3. Setup idetntity
            services.AddIdentity<Users, IdentityRole>().AddEntityFrameworkStores<INFPortObjectDbContext>();

            //4. Add identity server
            var builder = services.AddIdentityServer(options =>
            {
                options.Events.RaiseErrorEvents = true;
                options.Events.RaiseInformationEvents = true;
                options.Events.RaiseFailureEvents = true;
                options.Events.RaiseSuccessEvents = true;
            })
           .AddInMemoryApiScopes(Config.ApiScopes) // get scope
           .AddInMemoryClients(Configuration.GetSection("IdentityServer:Clients")) // used config in appsetting
                                                                                   //.AddInMemoryClients(Config.Clients) // used config in appsetting
           .AddInMemoryIdentityResources(Config.Ids) // get id
           .AddAspNetIdentity<Users>() // used user then managerment identity user
           .AddProfileService<IdentityProfile>()
           .AddDeveloperSigningCredential();

            // Add config Cors by cors key
            services.AddCors(options =>
            {
                options.AddPolicy(KspSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins(Configuration["AllowOrigins"])
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            //5. Configuration Identity When Login
            services.Configure<IdentityOptions>(options =>
            {
                // Default Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;
                options.SignIn.RequireConfirmedAccount = false;
                options.SignIn.RequireConfirmedEmail = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireDigit = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.User.RequireUniqueEmail = true;
            });

            //6.
            services.Configure<ApiBehaviorOptions>(options => { options.SuppressModelStateInvalidFilter = true; });

            //7.
            services.AddControllersWithViews().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<TacitReadRequestValidator>());

            //9. Add Authentication Key: Bear and value Client-id
            services.AddAuthentication("Bearer").AddJwtBearer("Bearer", options =>
            {
                options.Authority = "https://localhost:5000";

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false
                };
            });

            //10. Add Authorization
            services.AddAuthorization(options => { options.AddPolicy("Bearer", policy => { policy.AddAuthenticationSchemes("Bearer"); policy.RequireAuthenticatedUser(); }); });

            // Auto mapper
            // Add Config auto mapper
            var mappingConfig = new MapperConfiguration(mc => mc.AddProfile(new MappingTacit()));
            IMapper mapper = mappingConfig.CreateMapper(); // add create mapp
            services.AddSingleton(mapper); // Register Singleton for mapper

            //11. Add Razor pages loop find class model auto redirect page identity
            services.AddRazorPages(options =>
            {
                options.Conventions.AddAreaFolderRouteModelConvention("Identity", "/Account/", model =>
                {
                    foreach (var selector in model.Selectors)
                    {
                        var attributeRouteModel = selector.AttributeRouteModel;
                        attributeRouteModel.Order = -1;
                        attributeRouteModel.Template = attributeRouteModel.Template.Remove(0, "Identity".Length);
                    }
                });
            });

            //12. Register DI: Scope or Transient
            services.AddTransient<ITacitRepository, TacitRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IGroupRepository, GroupRepository>();
            services.AddScoped<IDapper, DapperBase>();

            // configure strongly typed settings object (use key value for appsetting file)
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

            //13. Configuration Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Port.Net API", Version = "v1" });

                // add defind openapi connect scope identity
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.OAuth2,
                    Flows = new OpenApiOAuthFlows
                    {
                        Implicit = new OpenApiOAuthFlow
                        {
                            AuthorizationUrl = new Uri("https://localhost:5000/connect/authorize"),
                            Scopes = new Dictionary<string, string> { { "api.portnet", "Port.Net API" } }
                        },
                    },
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
                        },
                        new List<string>{ "api.portnet" }
                    }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseErrorWrapping();

            app.UseStaticFiles();

            app.UseIdentityServer();

            app.UseAuthentication();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(KspSpecificOrigins);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
            });

            app.UseSwagger();

            app.UseMiddleware<JwtMiddleware>();

            app.UseSwaggerUI(c =>
            {
                c.OAuthClientId("swagger");
                c.OAuthAppName("Swagger Client");
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Port.Net API V1");
            });
        }
    }
}