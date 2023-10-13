using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Drawing.Text;
using MySql.Data.MySqlClient;
using Weekend.leerling.flappybird;

namespace Weekend.leerling
{
    public partial class leerling : Form
    {
        private flappybird.FlappyBird temp;
        protected virtual string GetConnectString()
        {
            return @"Server=127.0.0.1;Database=weekend;Uid=root;Pwd=;";
        }
        private void connection()
        {
            MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=reken-app;Uid=root;Pwd=;");
            try
            {
                connection.Open();
                // als er geen connectie is dan
                if (connection.State == ConnectionState.Open)
                {
                    // Test
                    MySqlCommand command = new MySqlCommand("SELECT * FROM Account", connection);
                    // Execute
                    MySqlDataReader reader = command.ExecuteReader();
                    // Read the data
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["Gebruikersnaam"]);
                    }
                    // Close the SqlDataReader object.
                    reader.Close();
                    label5.Text = "true";
                    Console.WriteLine("geen connectie");
                }
                //return
                else
                {
                    label5.Text = "false";
                    return;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Close the SqlConnection object.
                connection.Close();
            }
        }


        public leerling()
        {
            InitializeComponent();
        }

        private void scoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlScores.Visible = true;
            pnlHighS.Visible = false;
            pnlOpdrachten.Visible = false;
        }

        private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlHighS.Visible = true;
            pnlOpdrachten.Visible=false;
            pnlScores.Visible=false;
        }
        private void opdrachtenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOpdrachten.Visible = true;
            pnlScores.Visible=false;
            pnlHighS.Visible=false;
        }

        private void leerling_Load(object sender, EventArgs e)
        {
            connection();
            FillTextYESS();
            datum();
        }
        public void datum()
        {
            lblDatum.Text = DateTime.Now.ToString();
        }

        private void btnOpdr1_Click(object sender, EventArgs e)
        {
            pnlOpdr1.Show();
            
        }
        
        private void FlappyBird_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show(); // laat het orgigineel weer zien
        }

        private void WhackAMole_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true; // laat het orgigineel weer zien
        }

        private void FillTextYESS()
        {
            MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=reken-appe;Uid=root;Pwd=;");
            try
            {
                // als er geen connectie is dan
                if (connection == null)
                {
                    lblWelkom.Text = "systeem is offline probeer opnieuw later";
                }
                //return
                else
                {
                    Console.WriteLine("kon wel verbinden");
                    return;
                }
            }
            catch (MySqlException ex)
            {
                // Test
                MySqlCommand command = new MySqlCommand("SELECT `userID` FROM `score`", connection);
                // Execute
                MySqlDataReader reader = command.ExecuteReader();
                // Read the data
                while (reader.Read())
                {
                    txtScore.Text = reader.GetString(0);
                    //Console.WriteLine(reader["score"]);
                    if (reader.IsDBNull(0))
                    {
                        txtNaam.Text = "er zijn nog geen scores";
                    }
                }
                // Close the SqlDataReader object.
                reader.Close();
            }
            catch
            {
                txtScore.Text = "er kon niet verbonden worden";
            }
        }
        private void txtNaam_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOpdracht2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var game = new WhackAmole.Whack_A_Mole();
            game.FormClosed += WhackAMole_FormClosed;
            game.Visible = true;
        }

        private bool antwoorden(string juiste, string foute)
        {
            //som 1
            var random = new Random(); // Create a new instance of Random

            // Generate random numbers in the desired range
            var getal11 = random.Next(1, 11);
            var getal12 = random.Next(1, 10);
            
            lbSom11.Text = getal11.ToString(); // Assign the value of getal11 to lbSom11.Text
            lbSom12.Text = getal12.ToString(); // Assign the value of getal12 to lblSom12.Text

            var getal13 = getal11 + getal12;
            var antw1 = txtAntw1.Text;
            if (int.TryParse(antw1, out int antwoord))
            {
                if (getal13 == antwoord)
                {
                    return true;
                }
            }
            return false;

        }
        private void btnBev1_Click(object sender, EventArgs e)
        {
            if (antwoorden("juiste value", "foute value")) // Replace "juiste value" and "foute value" with appropriate string values
            {
                this.Hide();
                temp = new flappybird.FlappyBird();
                temp.FormClosed += FlappyBird_FormClosed; 
                temp.Show();
            }
            else
            {
                MessageBox.Show("probeer opnieuw");
            }
        }

    }
}
