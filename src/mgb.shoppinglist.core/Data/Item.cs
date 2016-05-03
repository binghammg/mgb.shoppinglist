using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace mgb.shoppinglist.core.Data
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int ItemId { get; set; }
        public int ItemCategoryId { get; set; }
        public string ItemDescription { get; set; }
        public int Quantity { get; set; }
        public bool AddedToCart { get; set; }
        public decimal Price { get; set; }
    }
}
