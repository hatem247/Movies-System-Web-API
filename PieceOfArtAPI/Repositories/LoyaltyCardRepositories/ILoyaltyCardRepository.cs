using PieceOfArtAPI.DTOs;

namespace PieceOfArtAPI.Repositories.LoyaltyCardRepositories
{
    public interface ILoyaltyCardRepository
    {
        void Add(LoyaltyCardAddDto loyaltyCard);
        void Delete(int Id);
    }
}
