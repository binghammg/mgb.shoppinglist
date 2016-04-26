using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mgb.shoppinglist.core
{
    public class Item
    {
        public int ItemId { get; set; }
        public int ItemCategoryId { get; set; }
        public string ItemDescription { get; set; }
        public int Quantity { get; set; }
        public int AddedToCart { get; set; }
        public decimal Price { get; set; }
    }
}
