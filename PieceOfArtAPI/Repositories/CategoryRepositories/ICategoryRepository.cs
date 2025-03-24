using PieceOfArtAPI.DTOs;

namespace PieceOfArtAPI.Repositories.CategoryRepositories
{
    public interface ICategoryRepository
    {
        void Add(CategoryAddDto category);
        void Update(CategoryUpdateDto category, int Id);
    }
}
