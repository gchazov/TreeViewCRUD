using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDTreeview
{
    // Подключение к БД
    internal class DBconnection
    {
        public static string connectionString;
        static public MySqlDataAdapter msDataAdapter;
        static MySqlConnection myConnection;
        static public MySqlCommand msCommand;

        public static bool Connect()
        {
            try
            {
                connectionString = $"server=localhost; user=test_user; password=test; database=web_travel";
                myConnection = new MySqlConnection(connectionString);
                myConnection.Open();
                msCommand = new MySqlCommand();
                msCommand.Connection = myConnection;
                msDataAdapter = new MySqlDataAdapter(msCommand);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static void Close()
        {
            myConnection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return myConnection;
        }
    }
}
