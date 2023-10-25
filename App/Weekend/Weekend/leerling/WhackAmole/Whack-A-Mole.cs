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
using System.Reflection;

namespace Weekend.leerling.WhackAmole
{
    public partial class Whack_A_Mole : Form
    {
        public Whack_A_Mole()
        {
            InitializeComponent();
            RNGesus();
        }
        private int a,b,k,score, q;
        private float c,d,f,g,h,i,j,Ans;

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private async void RNGesus()
        {
            await Task.Delay(5000);
            for (int x = 0; x++ < 30;)
            {
                Random rng = new Random();
                Random Delay1 = new Random();
                await Task.Delay(Convert.ToInt32(Delay1.Next(7500, 10000)));
                lblAss1.Text = lblAss2.Text = lblAss3.Text = lblAss4.Text = lblAss5.Text = lblAss6.Text = "...";
                var Ass = "";
                a = b = 0;
                int AssType = rng.Next(1, 4);
                switch (AssType)
                {
                    case 1:
                        
                        a = rng.Next(0, 1000);
                        b = rng.Next(0, 1000);
                        c = b + a;
                        Ass = b + "+" + a;
                        break;
                    case 2:
                        a = rng.Next(0, 100);
                        b = rng.Next(100, 1000);
                        c = b - a;
                        Ass = b + "-" + a;
                        break;
                    case 3:
                        a = rng.Next(0, 10);
                        b = rng.Next(0, 100);
                        c = b * a;
                        Ass = b + "*" + a;
                        break;
                    case 4:
                        a = rng.Next(0, 10);
                        b = rng.Next(0, 100);
                        c = b / a;
                        Ass = b + "/" + a;
                        break;
                }

                Random RNGHole = new Random();
                int Hole = RNGHole.Next(1, 6);
                switch (Hole)
                {
                    case 1:
                        lblAss1.Text = Ass;
                        d = c;
                        for (q = 7500; q > 0; q = q - 10)
                        {
                            if (k == 1)
                            {
                                score = score + q;
                                lblScore.Text = score.ToString();
                                lblAss1.Text = "...";
                                txtAnswer1.Text = "";
                                k = q = 0;
                                d = 0;
                                break;
                            }
                            else if (k == 2)
                            {
                                MessageBox.Show("Wrong.\nQuestion: " + Ass + ".\nYour Answer: " + Ans + ".\nCorrect Answer: " + d + ".");
                                lblAss1.Text = "...";
                                txtAnswer1.Text = "";
                                k = q = 0;
                                d = 0;
                                break;                             
                            }
                        await Task.Delay(10);
                        }
                        break;
                        case 2:
                        lblAss2.Text = Ass;
                        f = c;
                        for (q = 7500; q > 0; q = q - 10)
                        {
                            if (k == 1)
                            {
                                score = score + q;
                                lblScore.Text = score.ToString();
                                lblAss2.Text = "...";
                                txtAnswer1.Text = "";
                                k = q = 0;
                                f = 0;
                                break;
                            }
                            else if (k == 2)
                            {
                                MessageBox.Show("Wrong.\nQuestion: " + Ass + ".\nYour Answer: " + Ans + ".\nCorrect Answer: " + f + ".");
                                lblAss1.Text = "...";
                                txtAnswer1.Text = "";
                                k = q = 0;
                                f = 0;
                                break;
                            }
                            await Task.Delay(10);
                        }
                        break;
                    case 3:
                        lblAss3.Text = Ass;
                        g = c;
                        for (x = 7500; x - 10 > 0;)
                        {
                            if (k == 1)
                            {
                                score = score + x;
                                lblScore.Text = score.ToString();
                                lblAss3.Text = "";
                                break;
                            }
                            else
                            {
                                await Task.Delay(10);
                            }
                        }
                        break;
                    case 4:
                        lblAss4.Text = Ass;
                        h = c;
                        for (x = 7500; x - 10 > 0;)
                        {
                            if (k == 1)
                            {
                                score = score + x;
                                lblScore.Text = score.ToString();
                                lblAss4.Text = "";
                                break;
                            }
                            else
                            {
                                await Task.Delay(10);
                            }
                        }
                        break;
                    case 5:
                        lblAss5.Text = Ass;
                        i = c;
                        for (x = 7500; x - 10 > 0;)
                        {
                            if (k == 1)
                            {
                                score = score + x;
                                lblScore.Text = score.ToString();
                                lblAss5.Text = "...";
                                break;
                            }
                            else if (k == 2)
                            {
                                MessageBox.Show("Wrong \n. Question: " + Ass + "\nCorrect Answer = " + i + ".\n Your Answer: " + Ans + ".");
                                lblAss5.Text = "...";
                                break;
                            }
                            else
                            {
                                await Task.Delay(10);
                            }
                        }
                        break;
                    case 6:
                        lblAss6.Text = Ass;
                        j = c;
                        for (x = 7500; x - 10 > 0;)
                        {
                            if (k == 1)
                            {
                                score = score + x;
                                lblScore.Text = score.ToString();
                                lblAss6.Text = "";
                                break;
                            }
                            else
                            {
                                await Task.Delay(10);
                            }
                        }
                        break;
                }
            }
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtAnswer1_TextChange(object sender, EventArgs e)
        {

            if (!int.TryParse(txtAnswer1.Text, out int x) && txtAnswer1.Text.Length > 1)
            {

                txtAnswer1.Text = txtAnswer1.Text.Substring(0, txtAnswer1.Text.Length - 1);
                txtAnswer1.SelectionStart = txtAnswer1.Text.Length;
                txtAnswer1.SelectionLength = 0;
            }
            else if (!int.TryParse(txtAnswer1.Text, out int y))
            {
                txtAnswer1.Text = "";
            }
        
        }

        private void txtAnswer1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ans = Convert.ToInt32(txtAnswer1.Text);

                //MessageBox.Show("ans | " + d);
                if (Ans == d)
                {
                    k = 1;
                }
                else
                {
                    k = 2;
                }
            }
        }

        private void txtAnswer2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
// timer: per vraag -> 7.5 secondes. max tijd - de benodigede tijd om te antwoorden = resterende tijd -> score.