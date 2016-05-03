using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SQLite;
using System.IO;
using mgb.shoppinglist.core;
using System.Runtime;

namespace Sandbox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal),"database.db3");
            var db = new SQLiteConnection(dbPath);

            db.CreateTable<Item>();
        }
    }
}
