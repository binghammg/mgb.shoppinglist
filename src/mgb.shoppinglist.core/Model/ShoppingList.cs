using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mgb.shoppinglist.core.Model
{
    public class ShoppingList
    {
        public int ShoppingListId { get; set; }
        public List<Item> Items { get; set; }
    }
}
