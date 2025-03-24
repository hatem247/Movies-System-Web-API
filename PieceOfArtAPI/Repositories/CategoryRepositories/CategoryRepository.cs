using PieceOfArtAPI.Data;
using PieceOfArtAPI.DTOs;
using PieceOfArtAPI.Models;

namespace PieceOfArtAPI.Repositories.CategoryRepositories
{
    public class CategoryRepository : ICategoryRepository
    {
        protected readonly AppDbContext context;
        public CategoryRepository(AppDbContext _context) { context = _context; }
        public void Add(CategoryAddDto category)
        {
            Category newCategory = new Category
            {
                Name = category.Name,
                ArtPieces = context.ArtPieces.Where(p => category.ArtPiecesIds.Contains(p.Id)).ToList()
            };

            for(int i = 0; i < context.ArtPieces.Count(); i++)
            {
                if(!category.ArtPiecesIds.Contains(context.ArtPieces.ToList()[i].Id))
                {
                    throw new Exception("Art Piece not Found: " + context.ArtPieces.ToList()[i].Id);
                }
            }

            for(int i = 0; i < context.ArtPieces.Count(); i++)
            {
                context.ArtPieces.ToList()[i].Category = newCategory;
                context.ArtPieces.ToList()[i].CategoryId = newCategory.Id;
            }

            context.Categories.Add(newCategory);
            context.SaveChanges();
        }

        public void Update(CategoryUpdateDto category, int Id)
        {
            Category category1 = context.Categories.Find(Id);
            if (category1 == null) throw new Exception("Category not Found");
            else
            {
                category1.Name = category.Name;
                context.Categories.Update(category1);
                context.SaveChanges();
            }
        }
    }
}
