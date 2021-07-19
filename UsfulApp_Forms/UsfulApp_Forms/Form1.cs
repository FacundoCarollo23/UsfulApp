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
using FontAwesome.Sharp;
using System.Runtime.InteropServices;



namespace UsfulApp_Forms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        #region Menú y conección BD
        private IconButton currentBtn;
        private Panel leftBorder;
        private Form currentChildForm;

        private void Form1_Load(object sender, EventArgs e)
        {

            leftBorder = new Panel();
            leftBorder.Size = new Size(8, 44);
            Nav.Controls.Add(leftBorder);
         //   this.FormBorderStyle = FormBorderStyle.None;
         //   Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        private struct RgbColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(59, 122, 87);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(64, 224, 208);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(255, 255, 0);
            public static Color color7 = Color.FromArgb(238, 107, 0);
            public static Color color8 = Color.FromArgb(0, 104, 0);
        }

        private void ActivateButtom(object senderBtn, Color color)
        {
            CalendarButtom();
            if (senderBtn != null)
            {
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(50, 49, 69);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;

                leftBorder.BackColor = color;
                leftBorder.Location = new Point(0, currentBtn.Location.Y);
                leftBorder.Visible = true;
                leftBorder.BringToFront();
                Home.IconChar = IconChar.Home;
                Home.IconColor = color;
             
            }
        }

        private void CalendarButtom()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(50, 49, 69) ;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                Home.IconColor = Color.Gainsboro;
                Home.Text = "Home";

            }
        }


        private void Home_Click(object sender, EventArgs e)
        {
            Reset();
            currentChildForm.Close();
        }

        
        private void Event_Click(object sender, EventArgs e)
        {
            ActivateButtom(sender, RgbColors.color3);
            OpenChildForm(new FormEvents());
       
        }


        private void Settings_Click(object sender, EventArgs e)
        {
            ActivateButtom(sender, RgbColors.color2);
         
        }

        private void Login_Click(object sender, EventArgs e)
        {
            ActivateButtom(sender, RgbColors.color5);
            OpenChildForm(new Login());
        }

        private void Reset()
        {
            CalendarButtom();
            leftBorder.Visible = false;
        }
        /*
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        */
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Main.Controls.Add(childForm);
            Main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Nav.Text = childForm.Text;
        }

        /*
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        */

        #endregion


    


        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Nav_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
