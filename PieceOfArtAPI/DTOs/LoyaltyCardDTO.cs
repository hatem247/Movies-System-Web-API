using PieceOfArtAPI.Models;

namespace PieceOfArtAPI.DTOs
{
    public class LoyaltyCardGetDto
    {
        public int Id { get; set; }
        public int Balance { get; set; }
        public CustomerForArtPieceAndLoyaltyCardDto Customer { get; set; }
    }

    public class LoyaltyCardForCustomerDto
    {
        public int Id { get; set; }
        public int Balance { get; set; }
    }
    
    public class LoyaltyCardAddDto
    {
        public int Balance { get; set; }
        public int CustomerId { get; set; }
    }
}
