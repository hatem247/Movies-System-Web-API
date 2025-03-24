using PieceOfArtAPI.Data;
using PieceOfArtAPI.DTOs;
using PieceOfArtAPI.Models;

namespace PieceOfArtAPI.Repositories.ArtPiecesRepositories
{
    public class ArtPiecesRepository : IArtPiecesRepository
    {
        protected readonly AppDbContext context;
        public ArtPiecesRepository(AppDbContext _context) { context = _context; }
        public void Add(ArtPieceAddDto artPiece)
        {
            ArtPiece piece = new ArtPiece
            {
                Title = artPiece.Title,
                Description = artPiece.Description,
                Price = artPiece.Price,
                Category = context.Categories.Find(artPiece.CategoryId),
                Customer = context.Customers.Find(artPiece.CustomerId),
                CategoryId = artPiece.CategoryId,
                CustomerId = artPiece.CustomerId
            };
            context.ArtPieces.Add(piece);
            context.SaveChanges();
        }

        public List<ArtPieceGetDto> GetAll()
        {
            return context.ArtPieces.Select(p => new ArtPieceGetDto
            {
                Id = p.Id,
                Title = p.Title,
                Description = p.Description,
                Price = p.Price,
                Category = new CategoryForArtPieceDto
                {
                    Id = p.Category.Id,
                    Name = p.Category.Name
                },
                Customer = new CustomerForArtPieceAndLoyaltyCardDto
                {
                    Id = p.Customer.Id,
                    Name = p.Customer.Name,
                    Email = p.Customer.Email
                }
            }).ToList();
        }

        public ArtPieceGetDto GetbyId(int Id)
        {
            ArtPiece piece = context.ArtPieces.FirstOrDefault(p => p.Id == Id);
            if (piece == null) return null;
            return new ArtPieceGetDto
            {
                Id = piece.Id,
                Title = piece.Title,
                Description = piece.Description,
                Price = piece.Price,
                Category = new CategoryForArtPieceDto
                {
                    Id = piece.Category.Id,
                    Name = piece.Category.Name
                },
                Customer = new CustomerForArtPieceAndLoyaltyCardDto
                {
                    Id = piece.Customer.Id,
                    Name = piece.Customer.Name,
                    Email = piece.Customer.Email
                }
            };
        }
    }
}
