using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Security.Cryptography;

namespace Weekend.leerling.WhackAmole
{
    public partial class Whack_A_Mole : Form
    {
        public Whack_A_Mole()
        {
            InitializeComponent();
            RNGesus();
        }
        private async void RNGesus(){
            for(int x = 0; x < 30; x++) { 
                Random Delay2 = new Random();
                int a = 0, b = 0, c = 0;
                Random rng = new Random();
                int AssType = rng.Next(1, 4);
                switch (AssType)
                {
                    case 1:
                        a = rng.Next(0, 1000);
                        b = rng.Next(0, 1000);
                        c = b + a;
                        break;
                    case 2:
                        a = rng.Next(0, 1000);
                        b = rng.Next(0, 1000);
                        c = b - a;
                        break;
                    case 3:
                        a = rng.Next(0, 100);
                        b = rng.Next(0, 100);
                        c = b * a;
                        break;
                     case 4:
                        a = rng.Next(0, 10);
                        b = rng.Next(0, 100);
                        c = b / a;
                        break;
                }

                Random Delay1 = new Random();
                await Task.Delay(Convert.ToInt32(Delay1.Next(7500, 15000)));
          
                Random RNGHole = new Random();
                int Hole = RNGHole.Next(1, 6);
                switch (Hole)
                {
                    case 1:
                        lblAss1.Text = (a).ToString() + "+" + (b).ToString();
                        break;
                    case 2:
                        lblAss1.Text = (a).ToString() + "+" + (b).ToString();
                        break;
                    case 3:
                        lblAss1.Text = (a).ToString() + "+" + (b).ToString();
                        break;
                    case 4:
                        lblAss1.Text = (a).ToString() + "+" + (b).ToString();
                        break;
                    case 5:
                        lblAss1.Text = (a).ToString() + "+" + (b).ToString();
                        break;
                    case 6:
                        lblAss1.Text = (a).ToString() + "+" + (b).ToString();
                        break;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
