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
        public Admin()
        {
            InitializeComponent();
        }

        private void clearFields()
        {
            txtSearch.Clear();
            txtGebruikersnaam.Clear();
            txtEmail.Clear();
            txtRolID.Clear();
            txtVoornaam.Clear();
            txtTussenvoegsel.Clear();
            txtAchternaam.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblResult.Text = txtGebruikersnaam.Text;
            MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=reken-app;Uid=root;Pwd=;");
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                string stmt = "SELECT `Gebruikersnaam`,`Email`,`RolID`,`Voornaam`,`Tussenvoegsel`,`Achternaam` FROM account WHERE `Gebruikersnaam`=@Gebruiker;";
                MySqlCommand Sql = new MySqlCommand(stmt, connection);
                Sql.Parameters.AddWithValue("@AccountID", txtGebruikersnaam.Text);
                Sql.ExecuteReader();
            }
        }
    }
}
