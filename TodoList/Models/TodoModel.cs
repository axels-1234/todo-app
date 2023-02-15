using System;
using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class TodoModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(450)]
        public string UserId { get; set; }
        [Required]
        [MinLength(5)]
        public string Thing { get; set; }
        [Required]
        public DateTime Timestamp { get; set; }
        public DateTime? LastDate { get; set; }
    }
}
