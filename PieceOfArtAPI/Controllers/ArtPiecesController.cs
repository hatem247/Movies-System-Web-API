using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PieceOfArtAPI.DTOs;
using PieceOfArtAPI.Repositories.ArtPiecesRepositories;
using PieceOfArtAPI.Repositories.CustomerRepositories;

namespace PieceOfArtAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtPiecesController : ControllerBase
    {
        protected readonly IArtPiecesRepository repo;
        public ArtPiecesController(IArtPiecesRepository _repo) { repo = _repo; }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(repo.GetAll());
        }

        [HttpGet("GetbyId/{Id}")]
        public IActionResult GetbyId(int Id)
        {
            return Ok(repo.GetbyId(Id));
        }

        [HttpPost("Add")]
        public IActionResult Add(ArtPieceAddDto artPiece)
        {
            try
            {
                repo.Add(artPiece);
                return Created();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
