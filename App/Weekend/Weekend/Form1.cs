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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtWachtwoordLeraar = new System.Windows.Forms.TextBox();
            this.txtEmailLeraar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelLeraar = new System.Windows.Forms.Button();
            this.btnLogInLeraar = new System.Windows.Forms.Button();
            this.pnlLogInLeerling.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.label8.Location = new System.Drawing.Point(141, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(388, 80);
            this.label8.TabIndex = 5;
            this.label8.Text = "Student Log In";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.txtWachtwoordLeraar);
            this.panel1.Controls.Add(this.txtEmailLeraar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnCancelLeraar);
            this.panel1.Controls.Add(this.btnLogInLeraar);
            this.panel1.Location = new System.Drawing.Point(750, 566);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 347);
            this.panel1.TabIndex = 5;
            // 
            // txtWachtwoordLeraar
            // 
            this.txtWachtwoordLeraar.Location = new System.Drawing.Point(213, 161);
            this.txtWachtwoordLeraar.Name = "txtWachtwoordLeraar";
            this.txtWachtwoordLeraar.Size = new System.Drawing.Size(272, 22);
            this.txtWachtwoordLeraar.TabIndex = 7;
            // 
            // txtEmailLeraar
            // 
            this.txtEmailLeraar.Location = new System.Drawing.Point(213, 118);
            this.txtEmailLeraar.Name = "txtEmailLeraar";
            this.txtEmailLeraar.Size = new System.Drawing.Size(272, 22);
            this.txtEmailLeraar.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell Nova Cond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(152, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(363, 80);
            this.label9.TabIndex = 5;
            this.label9.Text = "Leraar Log In";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(77, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Wachtwoord:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(107, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Email:";
            // 
            // btnCancelLeraar
            // 
            this.btnCancelLeraar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLeraar.Location = new System.Drawing.Point(24, 224);
            this.btnCancelLeraar.Name = "btnCancelLeraar";
            this.btnCancelLeraar.Size = new System.Drawing.Size(307, 99);
            this.btnCancelLeraar.TabIndex = 1;
            this.btnCancelLeraar.Text = "Annuleer";
            this.btnCancelLeraar.UseVisualStyleBackColor = true;
            // 
            // btnLogInLeraar
            // 
            this.btnLogInLeraar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogInLeraar.Location = new System.Drawing.Point(337, 223);
            this.btnLogInLeraar.Name = "btnLogInLeraar";
            this.btnLogInLeraar.Size = new System.Drawing.Size(307, 99);
            this.btnLogInLeraar.TabIndex = 0;
            this.btnLogInLeraar.Text = "Log In";
            this.btnLogInLeraar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1924, 1049);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private Panel panel1;
        private TextBox txtWachtwoordLeraar;
        private TextBox txtEmailLeraar;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnCancelLeraar;
        private Button btnLogInLeraar;
    }
}
