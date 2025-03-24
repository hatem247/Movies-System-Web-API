namespace PieceOfArtAPI.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public List<ArtPiece> ArtPieces { get; set; }
        public LoyaltyCard LoyaltyCard { get; set; }
    }
}