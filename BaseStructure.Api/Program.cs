
using BaseStructure.Api.Config;
using BaseStructure.Application;
using BaseStructure.Infrastructure;

namespace BaseStructure.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Pobieranie konfiguracji z builder.Configuration
            IConfiguration configuration = builder.Configuration;

            // BaseStructure.Application project
            builder.Services.AddApplication();
            // BaseStructure.Infrastructure project
            builder.Services.AddInfrastructure();

            // Konfiguracja DatabaseConfiguration
            var databaseConfig = builder.Configuration.GetSection("ConnectionStrings").Get<DatabaseConfig>();


            // Dodawanie us³ug do kontenera
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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
