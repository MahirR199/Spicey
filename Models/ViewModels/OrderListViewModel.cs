using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spicey.Models.ViewModels
{
    public class OrderListViewModel
    {
        public IList<OrderDetailsViewModel> Orders { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
