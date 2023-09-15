using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weekend.leerling;

namespace Weekend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLeerling_Click(object sender, EventArgs e)
        {
            var temp = new leerling.leerling();
            temp.Show();
        }

        private Button button1;

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnInloggenLeerling = new System.Windows.Forms.Button();
            this.btnRegisteren = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 108);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInloggenLeerling
            // 
            this.btnInloggenLeerling.Location = new System.Drawing.Point(59, 62);
            this.btnInloggenLeerling.Name = "btnInloggenLeerling";
            this.btnInloggenLeerling.Size = new System.Drawing.Size(149, 84);
            this.btnInloggenLeerling.TabIndex = 1;
            this.btnInloggenLeerling.Text = "Log in \r\nLeerlingen";
            this.btnInloggenLeerling.UseVisualStyleBackColor = true;
            // 
            // btnRegisteren
            // 
            this.btnRegisteren.Location = new System.Drawing.Point(1662, 406);
            this.btnRegisteren.Name = "btnRegisteren";
            this.btnRegisteren.Size = new System.Drawing.Size(304, 109);
            this.btnRegisteren.TabIndex = 2;
            this.btnRegisteren.Text = "Registeren";
            this.btnRegisteren.UseVisualStyleBackColor = true;
            this.btnRegisteren.Click += new System.EventHandler(this.btnRegisteren_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInloggenLeerling);
            this.panel1.Location = new System.Drawing.Point(931, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 668);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1924, 1049);
            this.Controls.Add(this.btnRegisteren);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            var temp = new leerling.leerling();
            temp.Show();
        }

        private Button btnInloggenLeerling;
        private Button btnRegisteren;
        private Panel panel1;

        private void btnRegisteren_Click(object sender, EventArgs e)
        {

        }

        private Label label2;
        private Label label1;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Label label3;
        private TextBox txtWachtw;
        private TextBox txtGebr;
        private Button btnTerug;
        private Label label4;
        private TextBox txtNaam;
    }
}
