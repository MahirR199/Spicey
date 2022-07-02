using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Spicey.Models
{
    
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Category Name")]
        [Required]
        public String Name { get; set; }
    }
}
