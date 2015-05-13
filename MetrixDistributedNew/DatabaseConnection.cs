using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace MetrixDistributedNew
{
    public class DatabaseConnection
    {
       
            string cs = ConfigurationManager.ConnectionStrings["mdb"].ConnectionString;
            MySqlConnection conn;
            MySqlCommand cmd;

            public DatabaseConnection()
            {
                conn = new MySqlConnection();
            }

            public int Query(string sql)
            {
                int check = 0;
                cmd = new MySqlCommand(sql, conn);
                conn.Open();
                check = cmd.ExecuteNonQuery();
                conn.Close();
                return check;
            }

            public int CheckLId(string sql)
            {
                cmd = new MySqlCommand(sql, conn);
                conn.Open();
                int prevId = int.Parse(cmd.ExecuteScalar().ToString());
                conn.Close();
                if (prevId == 0)
                {
                    prevId = 1;
                }
                else
                {
                    prevId = +1;
                }
                return prevId;
            }

            public DataTable SearchQuery(string sql)
            {
                cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapt = new MySqlDataAdapter();
                DataTable DTable = new DataTable();
                conn.Open();
                adapt.Fill(DTable);
                conn.Close();
                return DTable;
            }
        }
    
}
