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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmailStudent = new System.Windows.Forms.TextBox();
            this.txtWachtwoordStudent = new System.Windows.Forms.TextBox();
            this.pnlLogInLeerling.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(337, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 99);
            this.button1.TabIndex = 0;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInloggenLeerling
            // 
            this.btnInloggenLeerling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnRegisteren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.pnlLogInLeerling.Controls.Add(this.txtWachtwoordStudent);
            this.pnlLogInLeerling.Controls.Add(this.txtEmailStudent);
            this.pnlLogInLeerling.Controls.Add(this.label8);
            this.pnlLogInLeerling.Controls.Add(this.label7);
            this.pnlLogInLeerling.Controls.Add(this.label6);
            this.pnlLogInLeerling.Controls.Add(this.btnCancel);
            this.pnlLogInLeerling.Controls.Add(this.button1);
            this.pnlLogInLeerling.Location = new System.Drawing.Point(42, 566);
            this.pnlLogInLeerling.Name = "pnlLogInLeerling";
            this.pnlLogInLeerling.Size = new System.Drawing.Size(668, 347);
            this.pnlLogInLeerling.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell Nova Cond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(133, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(408, 80);
            this.label8.TabIndex = 5;
            this.label8.Text = "Leerling Log In";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Wachtwoord:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(24, 224);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(307, 99);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Annuleer";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell Nova Cond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 80);
            this.label5.TabIndex = 4;
            this.label5.Text = "Welkom";
            // 
            // txtEmailStudent
            // 
            this.txtEmailStudent.Location = new System.Drawing.Point(213, 118);
            this.txtEmailStudent.Name = "txtEmailStudent";
            this.txtEmailStudent.Size = new System.Drawing.Size(272, 22);
            this.txtEmailStudent.TabIndex = 6;
            // 
            // txtWachtwoordStudent
            // 
            this.txtWachtwoordStudent.Location = new System.Drawing.Point(213, 161);
            this.txtWachtwoordStudent.Name = "txtWachtwoordStudent";
            this.txtWachtwoordStudent.Size = new System.Drawing.Size(272, 22);
            this.txtWachtwoordStudent.TabIndex = 7;
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
            this.Text = "RekenApp - Home";
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
        private Label label7;
        private Label label8;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private TextBox txtEmailStudent;
        private TextBox txtWachtwoordStudent;
    }
}
