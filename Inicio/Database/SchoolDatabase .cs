using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicio.Database
{
    public class SchoolDatabase
    {
        public void ExecuteInsert(string script)
        {
            SchoolConnection s = new SchoolConnection();
            MySqlConnection c = s.Create();

            MySqlCommand c1 = c.CreateCommand();
            c1.CommandText = script;

            c1.ExecuteNonQuery();
            c.Close();
        }


        public MySqlDataReader ExecuteSelect(string script)
        {
            SchoolConnection s = new SchoolConnection();
            MySqlConnection c = s.Create();

            MySqlCommand c1 = c.CreateCommand();
            c1.CommandText = script;

            MySqlDataReader r = c1.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return r;
        }
    }
}
