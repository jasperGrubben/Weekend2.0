using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Weekend.leerling.flappybird
{
    public partial class FlappyBird : Form
    {
        private int gravity = 5;
        private int pipeSpeed = 8;
        private int score = 0;
        private bool isJumping = false;

        public FlappyBird()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            lblStart.Visible = false;
            gravity = 5;
            pipeSpeed = 8;
            score = 0;
            lblScore.Text = $"Score: {score}";
            ResetBirdPos();
            ResetPipePosition();
        }

        private void UpdateBirdPosition()
        {
            if (isJumping)
            {
                pbBird.Top -= gravity * 2; // Jump higher when the space key is pressed
                isJumping = false;
            }
            else
            {
                pbBird.Top += gravity;
            }
        }

        private void UpdatePipePosition()
        {
            pbTopPipe.Left -= pipeSpeed;
            pbPipeDown.Left -= pipeSpeed;

            if (pbTopPipe.Left + pbTopPipe.Width < 0)
            {
                pbTopPipe.Left = this.Width;
                pbPipeDown.Left = this.Width;

                // Increase the score when pipes pass the screen
                score++;
                lblScore.Text = $"Score: {score}";
            }
        }

        private void ResetBirdPos()
        {
            pbBird.Left = 74;
            pbBird.Top = 182;
        }

        private void CheckCollision()
        {
            if (pbBird.Bounds.IntersectsWith(pbTopPipe.Bounds) || pbBird.Bounds.IntersectsWith(pbPipeDown.Bounds) ||
                pbBird.Bounds.IntersectsWith(pbGround.Bounds) || pbBird.Top < 0 || pbBird.Bottom > this.ClientSize.Height)
            {
                EndGame();
            }
        }

        private void ScoreDataB()
        { 
            var gebruikersid = Gevevens.Gebruikersnaam;
            MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=reken-appe;Uid=root;Pwd=;");
            var query = $"INSERT INTO `score`(`AccountID`, `score`) VALUES (gebruikersid,{score})";
        }
        private void EndGame()
        {
            tmrGame.Stop();
            ScoreDataB();
            MessageBox.Show($"Game Over! Your Score: {score}");
            InitializeGame();
        }

        private void ResetPipePosition()
        {
            pbTopPipe.Left = this.Width;
            pbPipeDown.Left = this.Width;
        }

        private void FlappyBird_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!tmrGame.Enabled)
                {
                    ResetBirdPos();
                    ResetPipePosition();
                    tmrGame.Start();
                }
                else
                {
                    isJumping = true; // Set isJumping to true to make the bird jump
                }
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            UpdateBirdPosition();
            UpdatePipePosition();
            CheckCollision();
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void pbTopPipe_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void pbGround_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
