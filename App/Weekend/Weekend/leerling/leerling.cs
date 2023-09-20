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

namespace Weekend.leerling
{
    public partial class leerling : Form
    {
        protected virtual string GetConnectString()
        {
            return @"Server=127.0.0.1;Database=weekend;Uid=root;Pwd=root;";
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
                        Console.WriteLine(reader["Username"]);
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
                    lblConnection.Text = "true";
                    return;
                }
            }
            catch (SqlException ex)
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

        private void lblconnection_Click(object sender, EventArgs e)
        {

        }
        public void datum()
        {
            lblDatum.Text = DateTime.Now.ToString();
        }

        private void btnOpdr1_Click(object sender, EventArgs e)
        {

        }

        private void FillTextYESS()
        {
            MySqlConnection connection = new SqlConnection("Server=127.0.0.1;Database=weekend;Uid=root;Pwd=;");
            try
            {
                // als er geen connectie is dan
                if (connection == null)
                {
                    lblWelkom.Text = "systeem is offline probeer opnieuw later";
                    lblConnection.Text = "false";
                }
                //return
                else
                {
                    lblConnection.Text = "true";
                    Console.WriteLine("kon wel verbinden");
                    return;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                connection.Open();
                // Test
                SqlCommand command = new SqlCommand("SELECT `userID` FROM `score`", connection);
                // Execute
                SqlDataReader reader = command.ExecuteReader();
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
    }
}
