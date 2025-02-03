using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntegreFYonAvmTool.Class;

namespace EntegreFYonAvmTool.Class
{
    public class CRUID
    {
        static DataTable dt;
        public static  DataTable  Listele(string query)
        {
            dt = new DataTable();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter(query, SqliteConnection.connection);
            adtr.Fill(dt);
            return dt;
        }
    }
}
