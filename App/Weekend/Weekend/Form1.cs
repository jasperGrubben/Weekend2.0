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

        private Button btnLogIn;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.btnRegisteren = new System.Windows.Forms.Button();
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelLogIn = new System.Windows.Forms.Button();
            this.lblWelkom = new System.Windows.Forms.Label();
            this.txtEmailLogIn = new System.Windows.Forms.TextBox();
            this.txtWachtwoordLogIn = new System.Windows.Forms.TextBox();
            this.pnlAccountAanmaken = new System.Windows.Forms.Panel();
            this.txtRegistreerVoornaam = new System.Windows.Forms.TextBox();
            this.txtRegistreerTussenvoegsels = new System.Windows.Forms.TextBox();
            this.lblRegistreer = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegisteerAnnuleer = new System.Windows.Forms.Button();
            this.btnRegistreerConfirm = new System.Windows.Forms.Button();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblTussenvoegsels = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblGebruikersNaamRegistreren = new System.Windows.Forms.Label();
            this.txtRegistreerEmail = new System.Windows.Forms.TextBox();
            this.txtRegistreerPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.txtRegistreerUsername = new System.Windows.Forms.TextBox();
            this.txtRegistreerAchternaam = new System.Windows.Forms.TextBox();
            this.lblHerhaalWachtwoord = new System.Windows.Forms.Label();
            this.pnlLogIn.SuspendLayout();
            this.pnlAccountAanmaken.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(337, 223);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(307, 99);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInloggen
            // 
            this.btnInloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInloggen.Location = new System.Drawing.Point(40, 175);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(329, 113);
            this.btnInloggen.TabIndex = 1;
            this.btnInloggen.Text = "Log in";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggenLeerling_Click);
            // 
            // btnRegisteren
            // 
            this.btnRegisteren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisteren.Location = new System.Drawing.Point(381, 175);
            this.btnRegisteren.Name = "btnRegisteren";
            this.btnRegisteren.Size = new System.Drawing.Size(329, 113);
            this.btnRegisteren.TabIndex = 2;
            this.btnRegisteren.Text = "Registeren";
            this.btnRegisteren.UseVisualStyleBackColor = true;
            this.btnRegisteren.Click += new System.EventHandler(this.btnRegisteren_Click);
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.Controls.Add(this.txtWachtwoordLogIn);
            this.pnlLogIn.Controls.Add(this.txtEmailLogIn);
            this.pnlLogIn.Controls.Add(this.lblLogIn);
            this.pnlLogIn.Controls.Add(this.label7);
            this.pnlLogIn.Controls.Add(this.label6);
            this.pnlLogIn.Controls.Add(this.btnCancelLogIn);
            this.pnlLogIn.Controls.Add(this.btnLogIn);
            this.pnlLogIn.Location = new System.Drawing.Point(36, 353);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(668, 347);
            this.pnlLogIn.TabIndex = 3;
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Rockwell Nova Cond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.Location = new System.Drawing.Point(233, 14);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(190, 80);
            this.lblLogIn.TabIndex = 5;
            this.lblLogIn.Text = "Log In";
            this.lblLogIn.Click += new System.EventHandler(this.label8_Click);
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
            // btnCancelLogIn
            // 
            this.btnCancelLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLogIn.Location = new System.Drawing.Point(24, 224);
            this.btnCancelLogIn.Name = "btnCancelLogIn";
            this.btnCancelLogIn.Size = new System.Drawing.Size(307, 99);
            this.btnCancelLogIn.TabIndex = 1;
            this.btnCancelLogIn.Text = "Annuleer";
            this.btnCancelLogIn.UseVisualStyleBackColor = true;
            // 
            // lblWelkom
            // 
            this.lblWelkom.AutoSize = true;
            this.lblWelkom.Font = new System.Drawing.Font("Rockwell Nova Cond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelkom.Location = new System.Drawing.Point(245, 39);
            this.lblWelkom.Name = "lblWelkom";
            this.lblWelkom.Size = new System.Drawing.Size(234, 80);
            this.lblWelkom.TabIndex = 4;
            this.lblWelkom.Text = "Welkom";
            // 
            // txtEmailLogIn
            // 
            this.txtEmailLogIn.Location = new System.Drawing.Point(213, 118);
            this.txtEmailLogIn.Name = "txtEmailLogIn";
            this.txtEmailLogIn.Size = new System.Drawing.Size(272, 22);
            this.txtEmailLogIn.TabIndex = 6;
            // 
            // txtWachtwoordLogIn
            // 
            this.txtWachtwoordLogIn.Location = new System.Drawing.Point(213, 161);
            this.txtWachtwoordLogIn.Name = "txtWachtwoordLogIn";
            this.txtWachtwoordLogIn.Size = new System.Drawing.Size(272, 22);
            this.txtWachtwoordLogIn.TabIndex = 7;
            // 
            // pnlAccountAanmaken
            // 
            this.pnlAccountAanmaken.Controls.Add(this.lblHerhaalWachtwoord);
            this.pnlAccountAanmaken.Controls.Add(this.txtRegistreerAchternaam);
            this.pnlAccountAanmaken.Controls.Add(this.txtRegistreerUsername);
            this.pnlAccountAanmaken.Controls.Add(this.txtPasswordConfirm);
            this.pnlAccountAanmaken.Controls.Add(this.txtRegistreerPassword);
            this.pnlAccountAanmaken.Controls.Add(this.txtRegistreerEmail);
            this.pnlAccountAanmaken.Controls.Add(this.lblGebruikersNaamRegistreren);
            this.pnlAccountAanmaken.Controls.Add(this.lblAchternaam);
            this.pnlAccountAanmaken.Controls.Add(this.lblTussenvoegsels);
            this.pnlAccountAanmaken.Controls.Add(this.lblVoornaam);
            this.pnlAccountAanmaken.Controls.Add(this.txtRegistreerVoornaam);
            this.pnlAccountAanmaken.Controls.Add(this.txtRegistreerTussenvoegsels);
            this.pnlAccountAanmaken.Controls.Add(this.lblRegistreer);
            this.pnlAccountAanmaken.Controls.Add(this.label9);
            this.pnlAccountAanmaken.Controls.Add(this.label10);
            this.pnlAccountAanmaken.Controls.Add(this.btnRegisteerAnnuleer);
            this.pnlAccountAanmaken.Controls.Add(this.btnRegistreerConfirm);
            this.pnlAccountAanmaken.Location = new System.Drawing.Point(738, 170);
            this.pnlAccountAanmaken.Name = "pnlAccountAanmaken";
            this.pnlAccountAanmaken.Size = new System.Drawing.Size(668, 530);
            this.pnlAccountAanmaken.TabIndex = 5;
            // 
            // txtRegistreerVoornaam
            // 
            this.txtRegistreerVoornaam.Location = new System.Drawing.Point(325, 114);
            this.txtRegistreerVoornaam.Name = "txtRegistreerVoornaam";
            this.txtRegistreerVoornaam.Size = new System.Drawing.Size(272, 22);
            this.txtRegistreerVoornaam.TabIndex = 7;
            // 
            // txtRegistreerTussenvoegsels
            // 
            this.txtRegistreerTussenvoegsels.Location = new System.Drawing.Point(325, 149);
            this.txtRegistreerTussenvoegsels.Name = "txtRegistreerTussenvoegsels";
            this.txtRegistreerTussenvoegsels.Size = new System.Drawing.Size(272, 22);
            this.txtRegistreerTussenvoegsels.TabIndex = 6;
            // 
            // lblRegistreer
            // 
            this.lblRegistreer.AutoSize = true;
            this.lblRegistreer.Font = new System.Drawing.Font("Rockwell Nova Cond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistreer.Location = new System.Drawing.Point(84, 18);
            this.lblRegistreer.Name = "lblRegistreer";
            this.lblRegistreer.Size = new System.Drawing.Size(513, 80);
            this.lblRegistreer.TabIndex = 5;
            this.lblRegistreer.Text = "Account Aanmaken";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(102, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Wachtwoord:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(128, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Email:";
            // 
            // btnRegisteerAnnuleer
            // 
            this.btnRegisteerAnnuleer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisteerAnnuleer.Location = new System.Drawing.Point(25, 405);
            this.btnRegisteerAnnuleer.Name = "btnRegisteerAnnuleer";
            this.btnRegisteerAnnuleer.Size = new System.Drawing.Size(307, 99);
            this.btnRegisteerAnnuleer.TabIndex = 1;
            this.btnRegisteerAnnuleer.Text = "Annuleer";
            this.btnRegisteerAnnuleer.UseVisualStyleBackColor = true;
            // 
            // btnRegistreerConfirm
            // 
            this.btnRegistreerConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistreerConfirm.Location = new System.Drawing.Point(338, 405);
            this.btnRegistreerConfirm.Name = "btnRegistreerConfirm";
            this.btnRegistreerConfirm.Size = new System.Drawing.Size(307, 99);
            this.btnRegistreerConfirm.TabIndex = 0;
            this.btnRegistreerConfirm.Text = "Registreer";
            this.btnRegistreerConfirm.UseVisualStyleBackColor = true;
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoornaam.Location = new System.Drawing.Point(106, 110);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(109, 25);
            this.lblVoornaam.TabIndex = 8;
            this.lblVoornaam.Text = "Voornaam:";
            // 
            // lblTussenvoegsels
            // 
            this.lblTussenvoegsels.AutoSize = true;
            this.lblTussenvoegsels.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTussenvoegsels.Location = new System.Drawing.Point(83, 145);
            this.lblTussenvoegsels.Name = "lblTussenvoegsels";
            this.lblTussenvoegsels.Size = new System.Drawing.Size(162, 25);
            this.lblTussenvoegsels.TabIndex = 9;
            this.lblTussenvoegsels.Text = "Tussenvoegsels:";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchternaam.Location = new System.Drawing.Point(106, 181);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(124, 25);
            this.lblAchternaam.TabIndex = 10;
            this.lblAchternaam.Text = "Achternaam:";
            // 
            // lblGebruikersNaamRegistreren
            // 
            this.lblGebruikersNaamRegistreren.AutoSize = true;
            this.lblGebruikersNaamRegistreren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruikersNaamRegistreren.Location = new System.Drawing.Point(83, 222);
            this.lblGebruikersNaamRegistreren.Name = "lblGebruikersNaamRegistreren";
            this.lblGebruikersNaamRegistreren.Size = new System.Drawing.Size(170, 25);
            this.lblGebruikersNaamRegistreren.TabIndex = 11;
            this.lblGebruikersNaamRegistreren.Text = "Gebruikers Naam:";
            // 
            // txtRegistreerEmail
            // 
            this.txtRegistreerEmail.Location = new System.Drawing.Point(325, 265);
            this.txtRegistreerEmail.Name = "txtRegistreerEmail";
            this.txtRegistreerEmail.Size = new System.Drawing.Size(272, 22);
            this.txtRegistreerEmail.TabIndex = 12;
            // 
            // txtRegistreerPassword
            // 
            this.txtRegistreerPassword.Location = new System.Drawing.Point(325, 305);
            this.txtRegistreerPassword.Name = "txtRegistreerPassword";
            this.txtRegistreerPassword.Size = new System.Drawing.Size(272, 22);
            this.txtRegistreerPassword.TabIndex = 13;
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(325, 343);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(272, 22);
            this.txtPasswordConfirm.TabIndex = 14;
            // 
            // txtRegistreerUsername
            // 
            this.txtRegistreerUsername.Location = new System.Drawing.Point(325, 226);
            this.txtRegistreerUsername.Name = "txtRegistreerUsername";
            this.txtRegistreerUsername.Size = new System.Drawing.Size(272, 22);
            this.txtRegistreerUsername.TabIndex = 15;
            // 
            // txtRegistreerAchternaam
            // 
            this.txtRegistreerAchternaam.Location = new System.Drawing.Point(325, 185);
            this.txtRegistreerAchternaam.Name = "txtRegistreerAchternaam";
            this.txtRegistreerAchternaam.Size = new System.Drawing.Size(272, 22);
            this.txtRegistreerAchternaam.TabIndex = 16;
            // 
            // lblHerhaalWachtwoord
            // 
            this.lblHerhaalWachtwoord.AutoSize = true;
            this.lblHerhaalWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerhaalWachtwoord.Location = new System.Drawing.Point(71, 339);
            this.lblHerhaalWachtwoord.Name = "lblHerhaalWachtwoord";
            this.lblHerhaalWachtwoord.Size = new System.Drawing.Size(201, 25);
            this.lblHerhaalWachtwoord.TabIndex = 17;
            this.lblHerhaalWachtwoord.Text = "Herhaal Wachtwoord:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1441, 931);
            this.Controls.Add(this.pnlAccountAanmaken);
            this.Controls.Add(this.lblWelkom);
            this.Controls.Add(this.btnRegisteren);
            this.Controls.Add(this.pnlLogIn);
            this.Controls.Add(this.btnInloggen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RekenApp - Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogIn.PerformLayout();
            this.pnlAccountAanmaken.ResumeLayout(false);
            this.pnlAccountAanmaken.PerformLayout();
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

        private Button btnInloggen;
        private Button btnRegisteren;
        private Panel pnlLogIn;

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
            pnlLogIn.Show();
        }

        private Label lblWelkom;
        private Button btnCancelLogIn;
        private Label label6;
        private Label label7;
        private Label lblLogIn;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private TextBox txtEmailLogIn;
        private TextBox txtWachtwoordLogIn;
        private Panel pnlAccountAanmaken;
        private TextBox txtRegistreerVoornaam;
        private TextBox txtRegistreerTussenvoegsels;
        private Label lblRegistreer;
        private Label label9;
        private Label label10;
        private Button btnRegisteerAnnuleer;
        private Button btnRegistreerConfirm;
        private Label lblGebruikersNaamRegistreren;
        private Label lblAchternaam;
        private Label lblTussenvoegsels;
        private Label lblVoornaam;
        private Label lblHerhaalWachtwoord;
        private TextBox txtRegistreerAchternaam;
        private TextBox txtRegistreerUsername;
        private TextBox txtPasswordConfirm;
        private TextBox txtRegistreerPassword;
        private TextBox txtRegistreerEmail;
    }
}
