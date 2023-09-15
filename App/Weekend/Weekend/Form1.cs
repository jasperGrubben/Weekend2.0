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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.btnInloggenLeerling = new System.Windows.Forms.Button();
            this.btnRegisteren = new System.Windows.Forms.Button();
            this.pnlLogInLeerling = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlLogInLeerling.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(337, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 99);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInloggenLeerling
            // 
            this.btnInloggenLeerling.Location = new System.Drawing.Point(40, 175);
            this.btnInloggenLeerling.Name = "btnInloggenLeerling";
            this.btnInloggenLeerling.Size = new System.Drawing.Size(329, 113);
            this.btnInloggenLeerling.TabIndex = 1;
            this.btnInloggenLeerling.Text = "Log in \r\nLeerlingen";
            this.btnInloggenLeerling.UseVisualStyleBackColor = true;
            this.btnInloggenLeerling.Click += new System.EventHandler(this.btnInloggenLeerling_Click);
            // 
            // btnRegisteren
            // 
            this.btnRegisteren.Location = new System.Drawing.Point(40, 310);
            this.btnRegisteren.Name = "btnRegisteren";
            this.btnRegisteren.Size = new System.Drawing.Size(329, 113);
            this.btnRegisteren.TabIndex = 2;
            this.btnRegisteren.Text = "Registeren";
            this.btnRegisteren.UseVisualStyleBackColor = true;
            this.btnRegisteren.Click += new System.EventHandler(this.btnRegisteren_Click);
            // 
            // pnlLogInLeerling
            // 
            this.pnlLogInLeerling.Controls.Add(this.label6);
            this.pnlLogInLeerling.Controls.Add(this.btnCancel);
            this.pnlLogInLeerling.Controls.Add(this.button1);
            this.pnlLogInLeerling.Location = new System.Drawing.Point(689, 12);
            this.pnlLogInLeerling.Name = "pnlLogInLeerling";
            this.pnlLogInLeerling.Size = new System.Drawing.Size(668, 546);
            this.pnlLogInLeerling.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell Nova Cond", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 54);
            this.label5.TabIndex = 4;
            this.label5.Text = "Welkom";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(24, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(307, 99);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Annuleer";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1924, 1049);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRegisteren);
            this.Controls.Add(this.pnlLogInLeerling);
            this.Controls.Add(this.btnInloggenLeerling);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogInLeerling.ResumeLayout(false);
            this.pnlLogInLeerling.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Panel pnlLogInLeerling;

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

        private void btnInloggenLeerling_Click(object sender, EventArgs e)
        {
            pnlLogInLeerling.Show();
        }

        private Label label5;
        private Button btnCancel;
        private Label label6;
    }
}
