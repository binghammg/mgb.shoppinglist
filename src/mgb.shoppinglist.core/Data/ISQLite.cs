using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;

namespace mgb.shoppinglist.core.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
