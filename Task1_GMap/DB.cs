using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Task1_GMap
{
    public class DB
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-7TGN5LN\SQLEXPRESS; Initial Catalog=task1_gmap;Integrated Security=True");

        public void openConnection()
        {
            sqlConnection.Open();
        }

        public void closeConnection()
        {
            sqlConnection.Close();
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }

   
}
