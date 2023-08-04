using System.ComponentModel.DataAnnotations;

namespace BookstoreApi.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Genre { get; set; }
        
        [Required]
        public string Description { get; set; }

        [Required]
        public int StockQuantity { get; set; }

    }
}