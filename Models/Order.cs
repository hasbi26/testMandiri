using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BookstoreApi.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }


        [Required]
        public string Status { get; set; }

    }
}