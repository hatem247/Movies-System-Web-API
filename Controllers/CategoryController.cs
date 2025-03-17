using Microsoft.AspNetCore.Mvc;
using Movies_System_Web_API.DTOs;
using Movies_System_Web_API.Repository.CategoryRepository;

namespace Movies_System_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public CategoryController(ICategoryRepo repo)
        {
            repo = repo;
        }
        [HttpPost("Add")]
        public IActionResult Add(CategoryDto categoryDto)
        {
            _repo.Add(categoryDto);
            return Ok();
        }
        [HttpPut("Update")]
        public IActionResult Update(CategoryDto categoryDto, int id)
        {
            try
            {
                _repo.Update(categoryDto, id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
