using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PieceOfArtAPI.Data;
using PieceOfArtAPI.DTOs;
using PieceOfArtAPI.Repositories.CustomerRepositories;

namespace PieceOfArtAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        protected readonly ICustomerRepository repo;
        public CustomersController(ICustomerRepository _repo) { repo = _repo; }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(repo.GetAll());
        }

        [HttpPost("Add")]
        public IActionResult Add(CustomerAddDto customer)
        {
            try
            {
                repo.Add(customer);
                return Ok(customer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("Update/{Id}")]
        public IActionResult Update(CustomerUpdateDto customer, int Id)
        {
            try
            {
                repo.Update(customer, Id);
                return Accepted();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
