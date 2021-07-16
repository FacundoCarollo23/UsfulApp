using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;


namespace UsfulApp_Forms
{
    class Consultas
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();

       

      

        public DataTable Mostrar()
        {
            cmd.CommandText = "Select * From Eventos";
            leer = cmd.ExecuteReader();
            tabla.Load(leer);

            return tabla;
        }



    }
}
