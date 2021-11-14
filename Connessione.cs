using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace login
{
    public static class Connessione
    {
        public static void Connect(string Query)
        {
            string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=login_db";
            MySqlConnection ConnessioneDB = new MySqlConnection(MySQLConnectionString);
            MySqlCommand ComandoDB = new MySqlCommand(Query, ConnessioneDB);
            ComandoDB.CommandTimeout = 60;
            ConnessioneDB.Open();
            ComandoDB.ExecuteReader();

        }
    }
}
