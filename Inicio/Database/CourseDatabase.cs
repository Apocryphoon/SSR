using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inicio.DTO;
using Inicio.Database;
using MySql.Data.MySqlClient;

namespace Inicio
{
    public class TrabDatabase 
        {
            public List<CourseDTO> listAllCourses()
            {
                string query = "Select * from tb_Curso";
                SchoolDatabase d = new SchoolDatabase();
                MySqlDataReader r = d.ExecuteSelect(query);

                List<CourseDTO> itens = new List<CourseDTO>();

                while (r.Read())
                {
                    CourseDTO t = new CourseDTO();
                    t.ID = r.GetInt32("id_trab");
                    t.Name = r.GetString("nm_nome");
                    t.Phone = r.GetString("nr_telefone");
                    t.Address = r.GetString("nm_endereco");
                    t.CellPhone = r.GetString("nm_celular");
                    t.Renewal = r.GetInt32("nr_data");

                    itens.Add(t);
                }
                return itens;
            }


            public void SaveCourse(CourseDTO trab)
            {
                string query = "INSERT INTO TB_CURSO (nm_nome, nm_endereco, nm_celular, nr_data, nr_telefone) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}' )";
                query = string.Format(query, trab.Name, trab.Phone, trab.Address, trab.CellPhone, trab.renewal);
                SchoolDatabase d = new SchoolDatabase();
                d.ExecuteInsert(query);
            }

      

    }
}
