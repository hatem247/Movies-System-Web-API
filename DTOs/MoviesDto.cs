namespace Movies_System_Web_API.DTOs
{
    public class MoviesDto
    {
        public string Title { get; set; }
        public DateTime ReleasaYear { get; set; } 
        public CategoryDto categoryDto { get; set; }
    }
}
