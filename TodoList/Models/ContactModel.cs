using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class ContactModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Category { get; set; }
        [Required]
        [MinLength(25)]
        public string Content { get; set; }
        [Required]
        public string UserId { get; set; }
    }
}
