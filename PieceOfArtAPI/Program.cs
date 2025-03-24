
using Microsoft.EntityFrameworkCore;
using PieceOfArtAPI.Data;
using PieceOfArtAPI.Repositories.ArtPiecesRepositories;
using PieceOfArtAPI.Repositories.CategoryRepositories;
using PieceOfArtAPI.Repositories.CustomerRepositories;
using PieceOfArtAPI.Repositories.LoyaltyCardRepositories;

namespace PieceOfArtAPI
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
            builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<IArtPiecesRepository, ArtPiecesRepository>();
            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddScoped<ILoyaltyCardRepository, LoyaltyCardRepository>();
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
