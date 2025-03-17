
using Microsoft.EntityFrameworkCore;
using Movies_System_Web_API.Repository.CategoryRepository;
using Movies_System_Web_API.Repository.CinemaRepository;
using Movies_System_Web_API.Repository.MovieRepository;

namespace Movies_System_Web_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var connection = builder.Configuration.GetConnectionString("Defaul");
            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));
            builder.Services.AddScoped<MovieRepo, MovieRepo>();
            builder.Services.AddScoped<ICinemaRepo, CinemaRepo>();
            builder.Services.AddScoped<ICategoryRepo, CategoryRepo>();
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
