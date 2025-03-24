using PieceOfArtAPI.Models;

namespace PieceOfArtAPI.DTOs
{
    public class CustomerGetDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public List<ArtPieceForCustomerDto> ArtPieces { get; set; }
        public LoyaltyCardForCustomerDto LoyaltyCard { get; set; }
    }

    public class CustomerAddDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<int> ArtPiecesIds { get; set; }
    }

    public class CustomerUpdateDto
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public List<int> ArtPiecesIds { get; set; }
        public int LoyaltyCardId { get; set; }
    }

    public class CustomerForArtPieceAndLoyaltyCardDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
