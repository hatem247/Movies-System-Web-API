using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PieceOfArtAPI.DTOs;
using PieceOfArtAPI.Repositories.CustomerRepositories;
using PieceOfArtAPI.Repositories.LoyaltyCardRepositories;

namespace PieceOfArtAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoyaltyCardsController : ControllerBase
    {
        protected readonly ILoyaltyCardRepository repo;
        public LoyaltyCardsController(ILoyaltyCardRepository _repo) { repo = _repo; }

        [HttpPost("Add")]
        public IActionResult Add(LoyaltyCardAddDto loyaltyCard)
        {
            try
            {
                repo.Add(loyaltyCard);
                return Ok("Loyalty Card Added Successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("Delete/{Id}")]
        public IActionResult Delete(int Id)
        {
            try
            {
                repo.Delete(Id);
                return Ok("Loyalty Card Deleted Successfully");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
