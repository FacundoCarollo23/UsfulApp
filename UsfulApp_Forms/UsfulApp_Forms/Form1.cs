using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UsfulApp_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Conexion c = new Conexion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
    
}
