using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RemziCicek
{
    class SqlConnectionObject
    {
        string database = Properties.Settings.Default.YonavmAracDatasıConnectionString;
        string db;

        public DataTable MDEQuery(string spName, Dictionary<string, string> param)
        {
            DataTable returnType = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server = 192.168.4.24; Database = MDE_GENEL; User Id = sa; Password = MagicUser2023!;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(spName, conn))
                {
                    cmd.CommandTimeout = 0;
                    if (param != null)
                    {
                        foreach (var item in param)
                        {
                            cmd.Parameters.AddWithValue(item.Key, item.Value);
                        }
                    }
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    adap.Fill(returnType);
                }
                conn.Close();
            }

            return returnType;
        }
        public DataTable Query(string spName, Dictionary<string, string> param)
        {
            DataTable returnType = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server = 192.168.4.24; Database = VDB_YON01; User Id = sa; Password = MagicUser2023!;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(spName, conn))
                {
                    cmd.CommandTimeout = 0;
                    if (param != null)
                    {
                        foreach (var item in param)
                        {
                            cmd.Parameters.AddWithValue(item.Key, item.Value);
                        }
                    }
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    adap.Fill(returnType);
                }
                conn.Close();
            }

            return returnType;
        }
        public DataTable Query2(string spName, Dictionary<string, string> param)
        {
            DataTable returnType = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server = 192.168.4.24; Database = VDB_YON01; User Id = sa; Password = MagicUser2023!;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(spName, conn))
                {
                    cmd.CommandTimeout = 0;
                    if (param != null)
                    {
                        foreach (var item in param)
                        {
                            cmd.Parameters.AddWithValue(item.Key, item.Value);
                        }
                    }
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    adap.Fill(returnType);
                }
                conn.Close();
            }

            return returnType;
        }
        public DataTable Query3(string spName)
        {
            db = database.ToString().Replace(@"\\", @"\");
            DataTable returnType = new DataTable();
            using (SqlConnection conn = new SqlConnection("Server = 192.168.4.24; Database = VDB_YON01; User Id = sa; Password = MagicUser2023!;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(spName, conn))
                {
                    cmd.CommandTimeout = 0;
                    SqlDataAdapter adap = new SqlDataAdapter(cmd);
                    adap.Fill(returnType);
                }
                conn.Close();
            }

            return returnType;

        }


        public void Insert(string spName, Dictionary<string, string> param)
        {
            using (SqlConnection conn = new SqlConnection("Server = 192.168.4.24; Database = VDB_YON01; User Id = sa; Password = MagicUser2023!;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(spName, conn))
                {
                    cmd.CommandTimeout = 0;
                    if (param != null)
                    {
                        foreach (var item in param)
                        {
                            cmd.Parameters.AddWithValue(item.Key, item.Value);
                        }
                    }
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

        }


        public void MDEInsert(string spName, Dictionary<string, string> param)
        {
            using (SqlConnection conn = new SqlConnection("Server = 192.168.4.24; Database = MDE_GENEL; User Id = sa; Password = MagicUser2023!;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(spName, conn))
                {
                    cmd.CommandTimeout = 0;
                    if (param != null)
                    {
                        foreach (var item in param)
                        {
                            cmd.Parameters.AddWithValue(item.Key, item.Value);
                        }
                    }
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

        }

        public string Insert2(string spName, Dictionary<string, string> param)
        {
            using (SqlConnection conn = new SqlConnection("Server = 192.168.4.24; Database = VDB_YON01; User Id = sa; Password = MagicUser2023!;"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(spName, conn))
                {
                    cmd.CommandTimeout = 0;
                    if (param != null)
                    {
                        foreach (var item in param)
                        {
                            if (item.Key == "@ReturnDesc")
                            {
                                cmd.Parameters.Add("@ReturnDesc", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue(item.Key, item.Value);
                            }
                        }
                    }
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();

                    return (string)cmd.Parameters["@ReturnDesc"].Value;
                }
            }

        }
        public String GetValue(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.VolConnection))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }
            if (dt.Rows != null)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return "";
            }
        }
        public DataTable GetData(string spName, SqlConnection sql)
        {
            DataTable returnType = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(spName, sql);
            da.Fill(returnType);
            if (returnType.Rows.Count > 0)
            {
                return returnType;
            }
            else
            {
                return null;
            }
        }
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

    }
}
