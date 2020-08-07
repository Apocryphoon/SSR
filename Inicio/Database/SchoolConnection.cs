using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio.Database
{
    public class SchoolConnection
    {
        public MySqlConnection Create()
        {
            string connectionString = "server=Localhost;database=EscolaDB;uid=root;pwd=1234";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }

    }


}


