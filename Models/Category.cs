using System.ComponentModel.DataAnnotations;

namespace api_service.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        [MinLength(3)]
        public string Title { get; set; }

    }
}
