using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace УП_МДК_01_01
{
    internal class DBConnection
    {
       static string DBConnect = @"Data Source=sql;Initial Catalog = уП01_ИСПП5_Работягова_АА; Integrated Security = True";
        static public SqlDataAdapter sqlDataAdapter;
        static SqlConnection sqlconnect;
        static public SqlCommand sqlCommand;
        

        public static bool ConnectionDB()
        {
            try
            {
                sqlconnect = new SqlConnection(DBConnect);
                sqlconnect.Open();
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlconnect;
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public static void ClassDB()
        {
            sqlconnect.Close();
        }
        public SqlConnection GetSqlConnection()
        {
            return sqlconnect;
        }

    }
}
