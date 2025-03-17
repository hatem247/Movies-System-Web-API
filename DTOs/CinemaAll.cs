using System.ComponentModel.DataAnnotations;

namespace Movies_System_Web_API.DTOs
{
    public class CinemaAll
    {
        [Required]
        public string Title { get; set; }
        public DateTime ReleaseYear { get; set; }
        public CategoryDto categoryDto { get; set; }
        public CinemaDto cinemaDto { get; set; }
    }
}
