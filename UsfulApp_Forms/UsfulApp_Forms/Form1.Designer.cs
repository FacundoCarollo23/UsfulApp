
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
            this.header = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Nav
            // 
            this.Nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.Nav.Location = new System.Drawing.Point(0, 0);
            this.Nav.Name = "Nav";
            this.Nav.Size = new System.Drawing.Size(157, 799);
            this.Nav.TabIndex = 0;
            // 
            // header
            // 
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(157, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1315, 45);
            this.header.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(157, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1314, 732);
            this.panel3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 799);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.header);
            this.Controls.Add(this.Nav);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Nav;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel panel3;
    }
}

