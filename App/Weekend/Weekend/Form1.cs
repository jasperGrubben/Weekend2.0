using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weekend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistatie_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        }
private void InitializeComponent()
        {
            this.btnLeerling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLeerling
            // 
            this.btnLeerling.Location = new System.Drawing.Point(1108, 42);
            this.btnLeerling.Name = "btnLeerling";
            this.btnLeerling.Size = new System.Drawing.Size(163, 65);
            this.btnLeerling.TabIndex = 0;
            this.btnLeerling.Text = "leerling";
            this.btnLeerling.UseVisualStyleBackColor = true;
            this.btnLeerling.Click += new System.EventHandler(this.btnLeerling_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1543, 566);
            this.Controls.Add(this.btnLeerling);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        private Button btnLeerling;

        private void btnLeerling_Click(object sender, EventArgs e)
        {
            
        }
    }
}
