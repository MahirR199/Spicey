using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Spicey.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Spiceyness { get; set; }
        public enum ESpicy { NA = 0, NotSpicy=1,Spicy=2,VerySpicey=3}
        public string Image { get; set; }
        [Display(Name="Category")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        
        [Display(Name = "SubCategory")]
        public int SubCategoryId { get; set; }
       
        [ForeignKey("SubCategoryId")]
        public virtual SubCategory SubCategory { get; set; }

        [Range(1,int.MaxValue, ErrorMessage=" Price should be greater than ${1}")]
        public double price { get; set; }
    }
}
