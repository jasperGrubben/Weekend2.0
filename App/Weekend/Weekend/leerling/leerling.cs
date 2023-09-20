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
                }
                //return
                else
                {
                    label5.Text = "false";
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
        }

        private void highScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlHighS.Visible = true;
        }

        private void opdrachtenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlOpdrachten.Visible = true;
        }

        private void leerling_Load(object sender, EventArgs e)
        {
            connection();
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
    }
}
