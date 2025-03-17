using System.ComponentModel.DataAnnotations;

namespace Movies_System_Web_API.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Placeholder { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
