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
            SqlConnection connection = new SqlConnection("Server=127.0.0.1;Database=weekend;Uid=root;Pwd=root;");
            try
            {
                // als er geen connectie is dan
                if (connection == null)
                {
                    connection.Open();
                    // Test
                    SqlCommand command = new SqlCommand("SELECT * FROM Users", connection);
                    // Execute
                    SqlDataReader reader = command.ExecuteReader();
                    // Read the data
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["Username"]);
                    }
                    // Close the SqlDataReader object.
                    reader.Close();
                }
                //return
                else
                {
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
        }

        private void lblconnection_Click(object sender, EventArgs e)
        {

        }
    }
}
