using PieceOfArtAPI.Models;

namespace PieceOfArtAPI.DTOs
{
    public class ArtPieceGetDto
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public CategoryForArtPieceDto Category { get; set; }
        public CustomerForArtPieceAndLoyaltyCardDto Customer { get; set; }
    }

    public class ArtPieceAddDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int CategoryId { get; set; }
        public int CustomerId { get; set; }
    }

    public class ArtPieceForCustomerDto
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public CategoryForArtPieceDto Category { get; set; }
    }

    public class ArtPieceForCategoryDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
    }
}
