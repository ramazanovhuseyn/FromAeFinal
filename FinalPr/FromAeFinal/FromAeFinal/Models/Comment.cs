using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FromAeFinal.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Message { get; set; }
        [Required]
        public string UserName { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
