using mgb.shoppinglist.core.Data;
using System.Collections.Generic;
using SQLite.Net;
using System.Linq;
using Xamarin.Forms;

namespace mgb.shoppinglist.core.Service
{
    public class ShoppingListService
    {
        private SQLiteConnection _dbconnection;

        public ShoppingListService()
        {
            _dbconnection = DependencyService.Get<ISQLite>().GetConnection();
            _dbconnection.CreateTable<Item>();
            _dbconnection.CreateTable<ItemCategory>();
            _dbconnection.CreateTable<ShoppingList>();
        }

        public List<ShoppingList> GetShoppingListList()
        {
            var tempsll = new List<ShoppingList>();

            return tempsll;
               
        }

        public List<Item> GetShoppingList(int ShoppingListId)
        {
            var templist = new List<Item>();
            return templist;
        }

        public void DeleteShoppingList(int ShoppingListId)
        {

        }

        public void SaveShoppingList(List<Item> ShoppingList)
        {

        }
        
        public Item GetItem(int ItemId)
        {
            var TempItem = new Item();
            return TempItem;
        }

        public void SaveItem(Item ShoppingListItem)
        {

        }

        public void DeleteItem(Item ShoppingListItem)
        {

        }

        public ItemCategory GetCategory(int ItemCategoryId)
        {
            var tempCategory = new ItemCategory();
            return tempCategory;
        }

        public void SaveCategory(ItemCategory Category)
        {

        }

        public void DeleteCategory(int ItemCategoryId)
        {

        }

    }
}
