using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CampusConnect.Forms
{
    class DBConnection
    {
       public static MySqlConnection GetConnection()
            {
                string connectionString = "server=localhost;user id=root;password=MUHAMMAD1122;database=campusconnect;";

                MySqlConnection con = new MySqlConnection(connectionString);

                return con;
            }
        }
    }

