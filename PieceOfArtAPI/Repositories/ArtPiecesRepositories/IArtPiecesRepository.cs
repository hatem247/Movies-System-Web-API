using PieceOfArtAPI.DTOs;

namespace PieceOfArtAPI.Repositories.ArtPiecesRepositories
{
    public interface IArtPiecesRepository
    {
        List<ArtPieceGetDto> GetAll();
        ArtPieceGetDto GetbyId(int Id);
        void Add(ArtPieceAddDto artPiece);
    }
}
