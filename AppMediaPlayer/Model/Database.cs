using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMediaPlayer.Model
{

    public class Database
    {
        static string server = "localhost";
        static string user = "root";
        static string pass = "123";
        static string db = "RythmBox";
        static int port = 3306;
        static string data = $"server={server};user={user};database={db};port={port};password={pass}";
        MySql.Data.MySqlClient.MySqlConnection con = new MySqlConnection(data);

        public Database()
        {
            con.Open();
        }


    }
}
