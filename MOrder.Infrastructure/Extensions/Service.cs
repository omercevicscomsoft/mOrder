using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using MOrder.Infrastructure.Context;
using MOrder.Infrastructure.Interfaces;
using MOrder.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOrder.Infrastructure.Extensions
{
    public static class Service
    {
        public static void ConfigureDBContext(this IServiceCollection services,
          IConfiguration configuration)
        {
            services.AddDbContextPool<DBContext>(opts =>
            {
                opts.UseSqlServer(configuration.GetValue<string>("Database:ConnectionStrings:DefaultConnection"));
            });
        }

        public static void ConfigureCors(this IServiceCollection services,
       IConfiguration configuration)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder
                    .WithOrigins(configuration
                       .GetSection("AllowedHosts")
                       .Get<string[]>())
                    .AllowAnyHeader()
                    .WithMethods("GET", "POST", "PUT", "DELETE", "OPTIONS")
                    .AllowCredentials();
                });
            });
        }

        public static void ConfigureSwager(this IServiceCollection services)
        {
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "MOrder API",
                    Version = "V1"
                });

                //ovdje se dalje dodaje ako treba autentifikacija
            });
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }
    }
}
