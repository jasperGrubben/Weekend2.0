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
            this.btnInloggen = new System.Windows.Forms.Button();
            this.btnRegisteren = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.txtGebr = new System.Windows.Forms.TextBox();
            this.txtWachtw = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 108);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInloggen
            // 
            this.btnInloggen.Location = new System.Drawing.Point(186, 619);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(304, 109);
            this.btnInloggen.TabIndex = 1;
            this.btnInloggen.Text = "Inloggen";
            this.btnInloggen.UseVisualStyleBackColor = true;
            // 
            // btnRegisteren
            // 
            this.btnRegisteren.Location = new System.Drawing.Point(1641, 619);
            this.btnRegisteren.Name = "btnRegisteren";
            this.btnRegisteren.Size = new System.Drawing.Size(304, 109);
            this.btnRegisteren.TabIndex = 2;
            this.btnRegisteren.Text = "Registeren";
            this.btnRegisteren.UseVisualStyleBackColor = true;
            this.btnRegisteren.Click += new System.EventHandler(this.btnRegisteren_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtWachtw);
            this.panel1.Controls.Add(this.txtGebr);
            this.panel1.Controls.Add(this.btnTerug);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNaam);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(564, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1035, 668);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "gebruikersnaam:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "naam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wachtwoord";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(392, 227);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(339, 31);
            this.txtNaam.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 61);
            this.label4.TabIndex = 4;
            this.label4.Text = "Registeren";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(872, 15);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(150, 48);
            this.btnTerug.TabIndex = 5;
            this.btnTerug.Text = "terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            // 
            // txtGebr
            // 
            this.txtGebr.Location = new System.Drawing.Point(392, 272);
            this.txtGebr.Name = "txtGebr";
            this.txtGebr.Size = new System.Drawing.Size(339, 31);
            this.txtGebr.TabIndex = 6;
            // 
            // txtWachtw
            // 
            this.txtWachtw.Location = new System.Drawing.Point(392, 325);
            this.txtWachtw.Name = "txtWachtw";
            this.txtWachtw.Size = new System.Drawing.Size(339, 31);
            this.txtWachtw.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(2079, 1049);
            this.Controls.Add(this.btnRegisteren);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnInloggen);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
