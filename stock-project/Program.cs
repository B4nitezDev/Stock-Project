using Application.Interfaces.Services;
using Infrastructure;
using Domain.Entity;
using Application.Interfaces.Repositories;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Services;

namespace stock_project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<DbContextStockManagement>(options => options.UseSqlServer(connectionString, b => b.MigrationsAssembly("stock-project")));
            
            // Add services to the container.
            builder.Services.AddScoped<IUserServices, UserService>();

            // Add repositories to the container.
            builder.Services.AddScoped(typeof(IRepository<User>), typeof(Repository<User>));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
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
