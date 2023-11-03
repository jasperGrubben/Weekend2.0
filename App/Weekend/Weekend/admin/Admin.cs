using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weekend.admin
{
    public partial class Admin : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=reken-app;Uid=root;Pwd=;");
        private string Gebruikersnaam, Email, Voornaam, Tussenvoegsel, Achternaam;
        private int AccountID, RolID;
        public Admin()
        {
            InitializeComponent();
        }

        private void lblChangePass_OnClick(object sender, EventArgs e)
        {

        }

        private void clearVars()
        {
            Gebruikersnaam = Email = Voornaam = Tussenvoegsel = Achternaam = "";
            AccountID = RolID = 0;
        }

        private void clearFields()
        {
            txtGebruikersnaam.Clear();
            txtEmail.Clear();
            txtRolID.Clear();
            txtVoornaam.Clear();
            txtTussenvoegsel.Clear();
            txtAchternaam.Clear();
        }

        private void btnDeleteConfirm_Click(object sender, EventArgs e)
        {
            string stmt = "DELETE FROM `account` WHERE `AccountID` = @AccountID";
            MySqlCommand Sql = new MySqlCommand(stmt, connection);
            Sql.Parameters.AddWithValue("@AccountID", AccountID);
            Sql.ExecuteNonQuery();
            clearVars();
            pnlDeleteConfirm.Visible = false;
            pnlGegevens.Enabled = true;
            pnlGegevens.Visible = false;
            btnSearch.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnlGegevens.Enabled = false;
            btnSearch.Enabled = false;
            pnlDeleteConfirm.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            clearFields();
            lblResult.Text = txtSearch.Text;
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                string stmt = "SELECT `Gebruikersnaam`,`Email`,`RolID`,`Voornaam`,`Tussenvoegsel`,`Achternaam`,`AccountID` FROM account WHERE `Gebruikersnaam`=@Gebruiker;";
                MySqlCommand Sql = new MySqlCommand(stmt, connection);
                Sql.Parameters.AddWithValue("@Gebruiker", txtSearch.Text);
                MySqlDataReader Reader = Sql.ExecuteReader();
                while (Reader.Read())
                {
                    Gebruikersnaam = Reader.GetString(0);
                    Email = Reader.GetString(1);
                    RolID = Reader.GetInt32(2);
                    Voornaam = Reader.GetString(3);
                    if (!Reader.IsDBNull(4))
                    {
                        Tussenvoegsel = Reader.GetString(4);
                    }
                    Achternaam = Reader.GetString(5);
                    AccountID = Reader.GetInt32(6);
                }
                txtGebruikersnaam.Text = Gebruikersnaam;
                txtEmail.Text = Email;
                txtRolID.Text = RolID.ToString();
                txtVoornaam.Text = Voornaam;
                txtTussenvoegsel.Text = Tussenvoegsel;
                txtAchternaam.Text = Achternaam;
                pnlGegevens.Visible = true;
                Reader.Close();
            }
        }
    }
}
