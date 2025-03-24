using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PieceOfArtAPI.DTOs;
using PieceOfArtAPI.Repositories.CategoryRepositories;
using PieceOfArtAPI.Repositories.CustomerRepositories;

namespace PieceOfArtAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        protected readonly ICategoryRepository repo;
        public CategoriesController(ICategoryRepository _repo) { repo = _repo; }

        [HttpPost("Add")]
        public IActionResult Add(CategoryAddDto category)
        {
            try
            {
                repo.Add(category);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update/{Id}")]
        public IActionResult Update(CategoryUpdateDto category, int Id)
        {
            try
            {
                repo.Update(category, Id);
                return Accepted();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
