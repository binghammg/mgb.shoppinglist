using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mgb.shoppinglist.core.Data
{
    public class ShoppingList
    {
        [PrimaryKey, AutoIncrement]
        public int ShoppingListId { get; set; }
        public string ShoppingListName { get; set; }
        public string ShoppingListDescription { get; set; }
        public List<Item> Items { get; set; }
    }
}
