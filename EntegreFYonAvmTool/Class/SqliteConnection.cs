using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace EntegreFYonAvmTool.Class
{
    public class SqliteConnection
    {
        public static SQLiteConnection connection = new SQLiteConnection("Data source=.\\Veritabani.db; Versiyon=3");
        
    }
}
