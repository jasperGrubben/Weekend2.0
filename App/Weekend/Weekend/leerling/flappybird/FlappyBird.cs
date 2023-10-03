using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weekend.leerling.flappybird
{
    public partial class FlappyBird : Form
    {

        private void FlappyBird_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }
        private int _gravity = 15;
        private int _pipeSpeed = 8;
        private int _score = 0;

        private void UpdateBirdPosition()
        {
            pbBird.Top += _gravity;
        }

        private void UpdatePipePosition()
        {
            pbTopPipe.Left -= _pipeSpeed;
            pbPipeDown.Left -= _pipeSpeed;
            pbGround.Location = new Point(-6, 776);
        }

        private void CountPipe()
        {
            if (pbTopPipe.Left < -pbTopPipe.Width)
            {
                // int pipeOffset = 300;
                pbTopPipe.Left = this.Width;
                pbPipeDown.Left = this.Width;

                _score++;
                lblScore.Text = $"Score: {_score}";
            }
        }

        private void ResetBirdPos()
        {
            pbBird.Left = 74;
            pbBird.Top = 182;
        }

        private void CheckCollision()
        {
            if (pbBird.Bounds.IntersectsWith(pbTopPipe.Bounds) || pbBird.Bounds.IntersectsWith(pbPipeDown.Bounds)
                || pbBird.Bounds.IntersectsWith(pbGround.Bounds) || pbBird.Top < 0)
            {
                EndGame();
            }
        }

        private void EndGame()
        {
            tmrGame.Stop();
            MessageBox.Show("Game Over !!");
        }

        public FlappyBird()
        {
            InitializeComponent();
            _gravity = 15;
            _pipeSpeed = 8;
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                //eersyte keer starten
                if (!tmrGame.Enabled)
                {
                    ResetBirdPos();
                    //pbBird.Location = new Point(148, 350);
                    ResetPipePosition();
                    pbGround.Location = new Point(-6, 776);
                    tmrGame.Start();
                }
                else
                {
                    _gravity = -15;
                }
            }
        }


        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                _gravity = 15;
            }

        }



        private void ResetPipePosition()
        {
            // int pipeOffset = 300;
            pbTopPipe.Left = 308;
            pbPipeDown.Left = 308;
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            UpdateBirdPosition();
            UpdatePipePosition();
            CountPipe();
            CheckCollision();

        }

        private void frmMain_KeyPress(object sender, KeyPressEventArgs e)
        {

            // if (e.KeyChar ==  (Char)Keys.Space)
            //{
            //    _gravity = 15;
            //}
        }
    }
}
