using Movies_System_Web_API.DTOs;

namespace Movies_System_Web_API.Repository.CategoryRepository
{
    public interface ICategoryRepo
    {
        public void Add(CategoryDto categoryDto);
        public bool Update(CategoryDto categoryDto, int id);
    }
}
