using System.ComponentModel.DataAnnotations;

namespace Movies_System_Web_API.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
