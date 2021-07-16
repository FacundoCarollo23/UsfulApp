
namespace UsfulApp_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nav = new System.Windows.Forms.Panel();
            this.Home = new FontAwesome.Sharp.IconButton();
            this.Settings = new FontAwesome.Sharp.IconButton();
            this.Event = new FontAwesome.Sharp.IconButton();
            this.Login = new FontAwesome.Sharp.IconButton();
            this.header = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Panel();
            this.Nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nav
            // 
            this.Nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.Nav.Controls.Add(this.Home);
            this.Nav.Controls.Add(this.Settings);
            this.Nav.Controls.Add(this.Event);
            this.Nav.Controls.Add(this.Login);
            this.Nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.Nav.Location = new System.Drawing.Point(0, 36);
            this.Nav.Name = "Nav";
            this.Nav.Size = new System.Drawing.Size(200, 793);
            this.Nav.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.Gainsboro;
            this.Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Home.IconColor = System.Drawing.Color.Gainsboro;
            this.Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home.IconSize = 32;
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(0, 180);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.Home.Size = new System.Drawing.Size(197, 44);
            this.Home.TabIndex = 8;
            this.Home.Text = "Home";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Settings
            // 
            this.Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.Gainsboro;
            this.Settings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.Settings.IconColor = System.Drawing.SystemColors.MenuBar;
            this.Settings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Settings.IconSize = 32;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(0, 330);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.Settings.Size = new System.Drawing.Size(194, 44);
            this.Settings.TabIndex = 7;
            this.Settings.Text = "Settimgs";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Event
            // 
            this.Event.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Event.FlatAppearance.BorderSize = 0;
            this.Event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Event.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event.ForeColor = System.Drawing.Color.Gainsboro;
            this.Event.IconChar = FontAwesome.Sharp.IconChar.CalendarWeek;
            this.Event.IconColor = System.Drawing.SystemColors.MenuBar;
            this.Event.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Event.IconSize = 32;
            this.Event.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Event.Location = new System.Drawing.Point(0, 230);
            this.Event.Name = "Event";
            this.Event.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.Event.Size = new System.Drawing.Size(194, 44);
            this.Event.TabIndex = 4;
            this.Event.Text = "Events";
            this.Event.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Event.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Event.UseVisualStyleBackColor = true;
            this.Event.Click += new System.EventHandler(this.Event_Click);
            // 
            // Login
            // 
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.FlatAppearance.BorderSize = 0;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Gainsboro;
            this.Login.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.Login.IconColor = System.Drawing.SystemColors.MenuBar;
            this.Login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Login.IconSize = 32;
            this.Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login.Location = new System.Drawing.Point(0, 280);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.Login.Size = new System.Drawing.Size(194, 44);
            this.Login.TabIndex = 6;
            this.Login.Text = "Login";
            this.Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1472, 36);
            this.header.TabIndex = 1;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(200, 36);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1272, 793);
            this.Main.TabIndex = 2;
            this.Main.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 829);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.Nav);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Nav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel header;
        private FontAwesome.Sharp.IconButton Event;
        private FontAwesome.Sharp.IconButton Settings;
        private FontAwesome.Sharp.IconButton Login;
        private FontAwesome.Sharp.IconButton Home;
        private System.Windows.Forms.Panel Nav;
        private System.Windows.Forms.Panel Main;
    }
}

