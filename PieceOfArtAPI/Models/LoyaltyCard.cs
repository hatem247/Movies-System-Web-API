namespace PieceOfArtAPI.Models
{
    public class LoyaltyCard
    {
        public int Id { get; set; }
        public int Balance { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
