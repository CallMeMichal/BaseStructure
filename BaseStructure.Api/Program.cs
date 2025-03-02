using BaseStructure.Api.Config;
using BaseStructure.Application;
using BaseStructure.Infrastructure;
using BaseStructure.Infrastructure.DatabaseModels.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BaseStructure.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            IConfiguration configuration = builder.Configuration;
            builder.Services.Configure<DatabaseConfig>(configuration.GetSection("ConnectionStrings"));

            // BaseStructure.Application project
            builder.Services.AddApplication();
            // BaseStructure.Infrastructure project
            builder.Services.AddInfrastructure();

            builder.Services.AddDbContext<AppDbContext>(options =>
            {               
               options.UseSqlServer(configuration.GetConnectionString("Default"),
               builder => builder.CommandTimeout(60)
               .UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)
               );
            });
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowLocalhost", builder =>
                {
                    builder.WithOrigins("http://localhost:3000") // Adres front-endu
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
            });

            // Dodawanie us³ug do kontenera
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            app.UseCors("AllowLocalhost");
            // Konfiguracja potoku HTTP
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            

            app.Run();
        }
    }
}
