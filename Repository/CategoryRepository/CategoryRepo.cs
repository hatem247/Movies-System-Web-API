using Movies_System_Web_API.DTOs;
using Movies_System_Web_API.Models;

namespace Movies_System_Web_API.Repository.CategoryRepository
{
    public class CategoryRepo : ICategoryRepo
    {
        private readonly AppDbContext _context;

        public CategoryRepo(AppDbContext context)
        {
            context = _context;
        }
        public void Add(CategoryDto categoryDto)
        {
            Category category = new Category
            {
                Name = "Hello, I changed myself 😁",
            };
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Update(CategoryDto categoryDto, int id)
        {
            var res = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (res == null)
            {
                res.Name = categoryDto.Name;
                _context.Categories.Remove(res);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Not Found");
            }
        }
    }
}
