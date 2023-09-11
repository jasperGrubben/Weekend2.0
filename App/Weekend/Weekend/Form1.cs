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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1543, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLeerling);
            this.Name = "Form1";
            this.Text = "b";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private Button btnLeerling;

        private void btnLeerling_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Button button1;

        private void button1_Click(object sender, EventArgs e)
        {
            var temp = new admin.FormAdmin();
            temp.Show();
        }
    }
}
