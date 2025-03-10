using housing_location_backend.Data;
using Microsoft.EntityFrameworkCore;

namespace housing_location_backend;

public class Program 
{
    public static void Main(string[] args)
    {      
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        
        var connectionString = builder.Configuration["WebAPIDbConnection"];
        builder.Services.AddDbContext<WebAPIDbContext>(options => options.UseSqlite(connectionString));

        builder.Services.AddScoped<IWebAPIRepo, DbWebAPIRepo>();
        
        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "housing_location_backend v1"));
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.MapControllers();

        app.Run();
    }
}
