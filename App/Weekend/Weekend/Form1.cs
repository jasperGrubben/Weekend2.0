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
            this.Hide();
            var temp = new leerling.leerling();
            temp.Show();
            temp.Close();
        }

        private Button btnLeerling;

        private void InitializeComponent()
        {
            this.btnLeerling = new System.Windows.Forms.Button();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.btnRegisteren = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnLeerling
            // 
            this.btnLeerling.Location = new System.Drawing.Point(144, 299);
            this.btnLeerling.Name = "btnLeerling";
            this.btnLeerling.Size = new System.Drawing.Size(359, 108);
            this.btnLeerling.TabIndex = 0;
            this.btnLeerling.Text = "button1";
            this.btnLeerling.UseVisualStyleBackColor = true;
            this.btnLeerling.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInloggen
            // 
            this.btnInloggen.Location = new System.Drawing.Point(578, 425);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(304, 109);
            this.btnInloggen.TabIndex = 1;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = true;
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
            this.panel1.Location = new System.Drawing.Point(931, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 668);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(2079, 1049);
            this.Controls.Add(this.btnRegisteren);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInloggen);
            this.Controls.Add(this.btnLeerling);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new leerling.leerling();
            temp.Show();
        }

        private Button btnInloggen;
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
