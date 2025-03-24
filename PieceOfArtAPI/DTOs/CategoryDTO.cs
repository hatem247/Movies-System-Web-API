using PieceOfArtAPI.Models;

namespace PieceOfArtAPI.DTOs
{
    public class CategoryGetDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<ArtPieceForCategoryDto> ArtPieces { get; set; }
    }

    public class CategoryForArtPieceDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CategoryAddDto
    {
        public string Name { get; set; }
        public List<int> ArtPiecesIds { get; set; }
    }

    public class CategoryUpdateDto
    {
        public string Name { get; set; }
    }
}
