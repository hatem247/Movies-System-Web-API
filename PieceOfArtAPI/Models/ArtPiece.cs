using System.ComponentModel;

namespace PieceOfArtAPI.Models
{
    public class ArtPiece
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
