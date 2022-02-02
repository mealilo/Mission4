using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class Categories
    {
        [Key]
        [Required]
        public int categoryID { get; set; }
        [Required]
        public string categoryName { get; set; }
    }
}
