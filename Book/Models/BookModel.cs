using System.ComponentModel.DataAnnotations;

namespace Book.Models
{
    public class BookModel
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
