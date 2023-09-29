using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weekend.leerling;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Weekend
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        static void DB_Connect()
        {
            MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=reken-app;Uid=root;Pwd=;");
        }


        static string ComputeSHA256Hash(string unhashedpass)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(unhashedpass);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                string hashedPassword = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                return hashedPassword;
            }
        }


        private void btnLeerling_Click(object sender, EventArgs e)
        {
            this.Hide();
            var temp = new leerling.leerling();
            temp.Show();
            temp.Close();
        }

        private Button btnLogIn;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnInloggen = new System.Windows.Forms.Button();
            this.txtWachtwoordLogIn = new System.Windows.Forms.TextBox();
            this.txtEmailLogIn = new System.Windows.Forms.TextBox();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelLogIn = new System.Windows.Forms.Button();
            this.lblWelkom = new System.Windows.Forms.Label();
            this.pnlRegistreer = new System.Windows.Forms.Panel();
            this.lblHerhaalWachtwoord = new System.Windows.Forms.Label();
            this.txtRegistreerAchternaam = new System.Windows.Forms.TextBox();
            this.txtRegistreerUsername = new System.Windows.Forms.TextBox();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.txtRegistreerPassword = new System.Windows.Forms.TextBox();
            this.txtRegistreerEmail = new System.Windows.Forms.TextBox();
            this.lblGebruikersNaamRegistreren = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblTussenvoegsels = new System.Windows.Forms.Label();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.txtRegistreerVoornaam = new System.Windows.Forms.TextBox();
            this.txtRegistreerTussenvoegsels = new System.Windows.Forms.TextBox();
            this.lblRegistreer = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegisteerAnnuleer = new System.Windows.Forms.Button();
            this.btnRegistreerConfirm = new System.Windows.Forms.Button();
            this.btnRegistreer = new System.Windows.Forms.Button();
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAccType = new System.Windows.Forms.ComboBox();
            this.pnlRegistreer.SuspendLayout();
            this.pnlLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(339, 214);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(307, 99);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInloggen
            // 
            this.btnInloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInloggen.Location = new System.Drawing.Point(43, 165);
            this.btnInloggen.Name = "btnInloggen";
            this.btnInloggen.Size = new System.Drawing.Size(329, 113);
            this.btnInloggen.TabIndex = 0;
            this.btnInloggen.Text = "Log in";
            this.btnInloggen.UseVisualStyleBackColor = true;
            this.btnInloggen.Click += new System.EventHandler(this.btnInloggenLeerling_Click);
            // 
            // txtWachtwoordLogIn
            // 
            this.txtWachtwoordLogIn.Location = new System.Drawing.Point(317, 157);
            this.txtWachtwoordLogIn.Name = "txtWachtwoordLogIn";
            this.txtWachtwoordLogIn.Size = new System.Drawing.Size(272, 22);
            this.txtWachtwoordLogIn.TabIndex = 1;
            // 
            // txtEmailLogIn
            // 
            this.txtEmailLogIn.Location = new System.Drawing.Point(317, 126);
            this.txtEmailLogIn.Name = "txtEmailLogIn";
            this.txtEmailLogIn.Size = new System.Drawing.Size(272, 22);
            this.txtEmailLogIn.TabIndex = 0;
            // 
            // lblLogIn
            // 
            this.lblLogIn.AutoSize = true;
            this.lblLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.Location = new System.Drawing.Point(224, 15);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(201, 69);
            this.lblLogIn.TabIndex = 5;
            this.lblLogIn.Text = "Log In";
            this.lblLogIn.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(139, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Wachtwoord:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email:";
            // 
            // btnCancelLogIn
            // 
            this.btnCancelLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLogIn.Location = new System.Drawing.Point(23, 214);
            this.btnCancelLogIn.Name = "btnCancelLogIn";
            this.btnCancelLogIn.Size = new System.Drawing.Size(307, 99);
            this.btnCancelLogIn.TabIndex = 3;
            this.btnCancelLogIn.Text = "Annuleer";
            this.btnCancelLogIn.UseVisualStyleBackColor = true;
            this.btnCancelLogIn.Click += new System.EventHandler(this.btnCancelLogIn_Click);
            // 
            // lblWelkom
            // 
            this.lblWelkom.AutoSize = true;
            this.lblWelkom.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelkom.Location = new System.Drawing.Point(245, 39);
            this.lblWelkom.Name = "lblWelkom";
            this.lblWelkom.Size = new System.Drawing.Size(252, 69);
            this.lblWelkom.TabIndex = 4;
            this.lblWelkom.Text = "Welkom";
            // 
            // pnlRegistreer
            // 
            this.pnlRegistreer.Controls.Add(this.cmbAccType);
            this.pnlRegistreer.Controls.Add(this.label8);
            this.pnlRegistreer.Controls.Add(this.label5);
            this.pnlRegistreer.Controls.Add(this.lblHerhaalWachtwoord);
            this.pnlRegistreer.Controls.Add(this.txtRegistreerAchternaam);
            this.pnlRegistreer.Controls.Add(this.txtRegistreerUsername);
            this.pnlRegistreer.Controls.Add(this.txtPasswordConfirm);
            this.pnlRegistreer.Controls.Add(this.txtRegistreerPassword);
            this.pnlRegistreer.Controls.Add(this.txtRegistreerEmail);
            this.pnlRegistreer.Controls.Add(this.lblGebruikersNaamRegistreren);
            this.pnlRegistreer.Controls.Add(this.lblAchternaam);
            this.pnlRegistreer.Controls.Add(this.lblTussenvoegsels);
            this.pnlRegistreer.Controls.Add(this.lblVoornaam);
            this.pnlRegistreer.Controls.Add(this.txtRegistreerVoornaam);
            this.pnlRegistreer.Controls.Add(this.txtRegistreerTussenvoegsels);
            this.pnlRegistreer.Controls.Add(this.lblRegistreer);
            this.pnlRegistreer.Controls.Add(this.label9);
            this.pnlRegistreer.Controls.Add(this.label10);
            this.pnlRegistreer.Controls.Add(this.btnRegisteerAnnuleer);
            this.pnlRegistreer.Controls.Add(this.btnRegistreerConfirm);
            this.pnlRegistreer.Location = new System.Drawing.Point(735, 21);
            this.pnlRegistreer.Name = "pnlRegistreer";
            this.pnlRegistreer.Size = new System.Drawing.Size(684, 596);
            this.pnlRegistreer.TabIndex = 100;
            this.pnlRegistreer.Visible = false;
            // 
            // lblHerhaalWachtwoord
            // 
            this.lblHerhaalWachtwoord.AutoSize = true;
            this.lblHerhaalWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHerhaalWachtwoord.Location = new System.Drawing.Point(71, 339);
            this.lblHerhaalWachtwoord.Name = "lblHerhaalWachtwoord";
            this.lblHerhaalWachtwoord.Size = new System.Drawing.Size(209, 25);
            this.lblHerhaalWachtwoord.TabIndex = 17;
            this.lblHerhaalWachtwoord.Text = "*Herhaal Wachtwoord:";
            // 
            // txtRegistreerAchternaam
            // 
            this.txtRegistreerAchternaam.Location = new System.Drawing.Point(325, 185);
            this.txtRegistreerAchternaam.Name = "txtRegistreerAchternaam";
            this.txtRegistreerAchternaam.Size = new System.Drawing.Size(272, 22);
            this.txtRegistreerAchternaam.TabIndex = 2;
            // 
            // txtRegistreerUsername
            // 
            this.txtRegistreerUsername.Location = new System.Drawing.Point(325, 226);
            this.txtRegistreerUsername.Name = "txtRegistreerUsername";
            this.txtRegistreerUsername.Size = new System.Drawing.Size(272, 22);
            this.txtRegistreerUsername.TabIndex = 3;
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(325, 343);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.Size = new System.Drawing.Size(272, 22);
            this.txtPasswordConfirm.TabIndex = 6;
            // 
            // txtRegistreerPassword
            // 
            this.txtRegistreerPassword.Location = new System.Drawing.Point(325, 305);
            this.txtRegistreerPassword.Name = "txtRegistreerPassword";
            this.txtRegistreerPassword.Size = new System.Drawing.Size(272, 22);
            this.txtRegistreerPassword.TabIndex = 5;
            // 
            // txtRegistreerEmail
            // 
            this.txtRegistreerEmail.Location = new System.Drawing.Point(325, 265);
            this.txtRegistreerEmail.Name = "txtRegistreerEmail";
            this.txtRegistreerEmail.Size = new System.Drawing.Size(272, 22);
            this.txtRegistreerEmail.TabIndex = 4;
            // 
            // lblGebruikersNaamRegistreren
            // 
            this.lblGebruikersNaamRegistreren.AutoSize = true;
            this.lblGebruikersNaamRegistreren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGebruikersNaamRegistreren.Location = new System.Drawing.Point(83, 222);
            this.lblGebruikersNaamRegistreren.Name = "lblGebruikersNaamRegistreren";
            this.lblGebruikersNaamRegistreren.Size = new System.Drawing.Size(178, 25);
            this.lblGebruikersNaamRegistreren.TabIndex = 11;
            this.lblGebruikersNaamRegistreren.Text = "*Gebruikers Naam:";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAchternaam.Location = new System.Drawing.Point(106, 181);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(132, 25);
            this.lblAchternaam.TabIndex = 10;
            this.lblAchternaam.Text = "*Achternaam:";
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
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoornaam.Location = new System.Drawing.Point(106, 110);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(117, 25);
            this.lblVoornaam.TabIndex = 8;
            this.lblVoornaam.Text = "*Voornaam:";
            // 
            // txtRegistreerVoornaam
            // 
            this.txtRegistreerVoornaam.Location = new System.Drawing.Point(325, 114);
            this.txtRegistreerVoornaam.Name = "txtRegistreerVoornaam";
            this.txtRegistreerVoornaam.Size = new System.Drawing.Size(272, 22);
            this.txtRegistreerVoornaam.TabIndex = 0;
            // 
            // txtRegistreerTussenvoegsels
            // 
            this.txtRegistreerTussenvoegsels.Location = new System.Drawing.Point(325, 149);
            this.txtRegistreerTussenvoegsels.Name = "txtRegistreerTussenvoegsels";
            this.txtRegistreerTussenvoegsels.Size = new System.Drawing.Size(272, 22);
            this.txtRegistreerTussenvoegsels.TabIndex = 1;
            // 
            // lblRegistreer
            // 
            this.lblRegistreer.AutoSize = true;
            this.lblRegistreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistreer.Location = new System.Drawing.Point(84, 18);
            this.lblRegistreer.Name = "lblRegistreer";
            this.lblRegistreer.Size = new System.Drawing.Size(563, 69);
            this.lblRegistreer.TabIndex = 5;
            this.lblRegistreer.Text = "Account Aanmaken";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(102, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "*Wachtwoord:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(128, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "*Email:";
            // 
            // btnRegisteerAnnuleer
            // 
            this.btnRegisteerAnnuleer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisteerAnnuleer.Location = new System.Drawing.Point(25, 431);
            this.btnRegisteerAnnuleer.Name = "btnRegisteerAnnuleer";
            this.btnRegisteerAnnuleer.Size = new System.Drawing.Size(307, 99);
            this.btnRegisteerAnnuleer.TabIndex = 8;
            this.btnRegisteerAnnuleer.Text = "Annuleer";
            this.btnRegisteerAnnuleer.UseVisualStyleBackColor = true;
            this.btnRegisteerAnnuleer.Click += new System.EventHandler(this.btnRegisteerAnnuleer_Click);
            // 
            // btnRegistreerConfirm
            // 
            this.btnRegistreerConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistreerConfirm.Location = new System.Drawing.Point(338, 431);
            this.btnRegistreerConfirm.Name = "btnRegistreerConfirm";
            this.btnRegistreerConfirm.Size = new System.Drawing.Size(307, 99);
            this.btnRegistreerConfirm.TabIndex = 7;
            this.btnRegistreerConfirm.Text = "Registreer";
            this.btnRegistreerConfirm.UseVisualStyleBackColor = true;
            this.btnRegistreerConfirm.Click += new System.EventHandler(this.btnRegistreerConfirm_Click);
            // 
            // btnRegistreer
            // 
            this.btnRegistreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistreer.Location = new System.Drawing.Point(390, 165);
            this.btnRegistreer.Name = "btnRegistreer";
            this.btnRegistreer.Size = new System.Drawing.Size(329, 113);
            this.btnRegistreer.TabIndex = 1;
            this.btnRegistreer.Text = "Registreer";
            this.btnRegistreer.UseVisualStyleBackColor = true;
            this.btnRegistreer.Click += new System.EventHandler(this.btnRegistreer_Click);
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.Controls.Add(this.btnLogIn);
            this.pnlLogIn.Controls.Add(this.btnCancelLogIn);
            this.pnlLogIn.Controls.Add(this.label6);
            this.pnlLogIn.Controls.Add(this.label7);
            this.pnlLogIn.Controls.Add(this.txtWachtwoordLogIn);
            this.pnlLogIn.Controls.Add(this.lblLogIn);
            this.pnlLogIn.Controls.Add(this.txtEmailLogIn);
            this.pnlLogIn.Location = new System.Drawing.Point(42, 304);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(668, 347);
            this.pnlLogIn.TabIndex = 7;
            this.pnlLogIn.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "*Account Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(130, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "* = verplicht";
            // 
            // cmbAccType
            // 
            this.cmbAccType.FormattingEnabled = true;
            this.cmbAccType.Items.AddRange(new object[] {
            "Student",
            "Docent"});
            this.cmbAccType.Location = new System.Drawing.Point(325, 375);
            this.cmbAccType.Name = "cmbAccType";
            this.cmbAccType.Size = new System.Drawing.Size(272, 24);
            this.cmbAccType.TabIndex = 20;
            // 
            // Homepage
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1444, 652);
            this.Controls.Add(this.pnlLogIn);
            this.Controls.Add(this.btnRegistreer);
            this.Controls.Add(this.pnlRegistreer);
            this.Controls.Add(this.lblWelkom);
            this.Controls.Add(this.btnInloggen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Homepage";
            this.Text = "RekenApp - Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlRegistreer.ResumeLayout(false);
            this.pnlRegistreer.PerformLayout();
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //login knop
        private void button1_Click(object sender, EventArgs e)
        {
            var email = txtEmailLogIn.Text;
            var pass = txtWachtwoordLogIn.Text;
            var passconfirm = txtPasswordConfirm.Text;

            if (pass == passconfirm) {
                if (email == "" || pass == "")
                {
                    MessageBox.Show("vul alle velden in");
                    return;
                }
                else
                {
                    // Create a SHA3_256 hasher
                    using (SHA256 sha3 = SHA256.Create())
                    {
                        // Convert the password string to bytes
                        byte[] passwordBytes = Encoding.UTF8.GetBytes(pass);

                        // Compute the hash
                        byte[] hashBytes = sha3.ComputeHash(passwordBytes);

                        // Convert the hash to a hexadecimal string
                        string hashedPassword = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                        // Now you can use the hashedPassword for storage or comparison
                        // For example, you can store it in a database and compare it when a user logs in.
                    }
                }

            }
        }

        private Button btnInloggen;


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            pnlLogIn.Visible = true;
        }


        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtWachtw;
        private TextBox txtGebr;
        private Button btnTerug;
        private Label label4;
        private TextBox txtNaam;

        private void btnInloggenLeerling_Click(object sender, EventArgs e)
        {
            pnlLogIn.Show();
            pnlLogIn.Location = new System.Drawing.Point(42, 18);
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
        private Panel pnlRegistreer;
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

        private void btnRegisteerAnnuleer_Click(object sender, EventArgs e)
        {
            pnlRegistreer.Visible = false;
            btnRegistreer.Visible = true;
        }

        private void btnCancelLogIn_Click(object sender, EventArgs e)
        {
            pnlLogIn.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private Button btnRegistreer;
        private Panel pnlLogIn;

        private void btnRegistreer_Click(object sender, EventArgs e)
        {
            pnlRegistreer.Visible = true;
            btnRegistreer.Visible = false;
            pnlRegistreer.Location = new System.Drawing.Point(42,12);

        }

        private void btnRegistreerConfirm_Click(object sender, EventArgs e)
        {
            var fname = txtRegistreerVoornaam.Text;
            var Infix = txtRegistreerTussenvoegsels.Text;
            var lname = txtRegistreerAchternaam.Text;
            var usn = txtRegistreerUsername.Text;
            var email = txtRegistreerEmail.Text;
            var pass = txtRegistreerPassword.Text;
            var passconfirm = txtPasswordConfirm.Text;
            var selectedrole = Convert.ToString(cmbAccType.SelectedItem);
            var role = "";
            switch (selectedrole)
            {
                case "Student":
                    role = "3";
                    break;
                case "Docent":
                    role = "2";
                    break;
            }
            if (fname != "" || lname != "" || usn != "" || email != "" || pass != "" || passconfirm != "" || role != "")
            {
                if (pass == passconfirm)
                {
                    ComputeSHA256Hash(pass);
                    DB_Connect();
                    MySqlCommand q = new MySqlCommand("INSERT INTO account(email, pass) VALUES (@email, @pass)");

                }
                else
                {
                    MessageBox.Show("vul alle velden in verplichte* velden in");
                    return;
                }
            }
            else
            { 
            }
        }

        private ComboBox cmbAccType;
        private Label label8;
        private Label label5;
    }
}
