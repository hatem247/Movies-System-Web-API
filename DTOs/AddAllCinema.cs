using System.ComponentModel.DataAnnotations;

namespace Movies_System_Web_API.DTOs
{
    public class AddAllCinema
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int Placeholder { get; set; }
        public List<MoviesDto> moviesDtos { get; set; }
    }
}
