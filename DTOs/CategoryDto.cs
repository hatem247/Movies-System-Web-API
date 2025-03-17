using System.ComponentModel.DataAnnotations;

namespace Movies_System_Web_API.DTOs
{
    public class CategoryDto
    {
        [Required]
        public string Name { get; set; }
    }
}
