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
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
            try
            {
               cn = new SqlConnection("Data Source=usefulapp1.c0rxhojittix.us-east-2.rds.amazonaws.com;Initial Catalog=usefulapp;Persist Security Info=True;User ID=admin;Password=francoromano");
                cn.Open();
                MessageBox.Show("Conectado");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Conexion incorrecta :" + ex.ToString());
            }
        }

    }
}
