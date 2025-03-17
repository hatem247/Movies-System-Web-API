using Microsoft.AspNetCore.Mvc;
using Movies_System_Web_API.DTOs;
using Movies_System_Web_API.Repository.CinemaRepository;

namespace Movies_System_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly ICinemaRepo _repo;

        public CinemaController(ICinemaRepo repo)
        {
            _repo = repo;
        }
        [HttpPost("GetAll")]
        public IActionResult Add(AddAllCinema addAllCinema)
        {
            _repo.Add(addAllCinema);
            return Ok();
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var res = _repo.GetAll();
            return Ok(res);
        }
        [HttpPut("Update")]
        public IActionResult Update(AddAllCinema updateAllCinema, int id)
        {
            try
            {
                _repo.Update(updateAllCinema, id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
