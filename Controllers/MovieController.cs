using Microsoft.AspNetCore.Mvc;
using Movies_System_Web_API.DTOs;
using Movies_System_Web_API.Repository.MovieRepository;

namespace Movies_System_Web_API.Controllers
{
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepo _repo;

        public MovieController(IMovieRepo repo)
        {
            _repo = repo;
        }

        [HttpPost()]
        public IActionResult Add(CinemaAll addAll)
        {
            _repo.Add(addAll);
            return Ok();
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var res = _repo.GetAll();
            return Ok(res);
        }

        [HttpGet("Add")]
        public IActionResult GetById(int id)
        {
            try
            {
                var res = _repo.GetById(id);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
