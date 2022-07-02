using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spicey.Models.ViewModels
{
    public class SubCategoryAndCategoryViewModel
    {
        public IEnumerable<Category> CategoryList { get; set; }
        public SubCategory SubCategory { get; set; }
        public List<String> SubCategoryList { get; set; }

        public String StatusMessage { get; set; }
    }
}
