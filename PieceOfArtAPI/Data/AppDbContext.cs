using Microsoft.EntityFrameworkCore;
using PieceOfArtAPI.Models;

namespace PieceOfArtAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<ArtPiece> ArtPieces { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<LoyaltyCard> LoyaltyCards { get; set; }
    }
}
