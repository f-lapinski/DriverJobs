using HealthChecks.UI.Client;
using IdentityModel.Client;
using Infrastructure.HealthChecks;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

namespace DriverJobs;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
    
        builder.Services.AddControllers();
        
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();
        builder.Services.AddSwaggerGen();

        builder.Services.AddHealthChecks()
            .AddCheck<TestHealthCheck>("Test Health Check");

        builder.Services.AddHealthChecksUI(options =>
            {
                options.AddHealthCheckEndpoint("API", "/hc");

            })
            .AddInMemoryStorage();
            
        

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.MapHealthChecks("/hc", new HealthCheckOptions
        {
            ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
        });

        app.MapHealthChecksUI(options =>
        {
            options.UIPath = "/hc-ui";
        });
        
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}