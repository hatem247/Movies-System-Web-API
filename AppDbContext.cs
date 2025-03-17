using Microsoft.EntityFrameworkCore;
using Movies_System_Web_API.Models;

namespace Movies_System_Web_API
{
    public class AppDbContext: DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
    }
}
