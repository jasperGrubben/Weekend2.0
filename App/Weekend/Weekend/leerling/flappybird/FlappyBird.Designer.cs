namespace Weekend.leerling.flappybird
{
    partial class FlappyBird
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbTopPipe = new System.Windows.Forms.PictureBox();
            this.pbPipeDown = new System.Windows.Forms.PictureBox();
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.lblStart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTopPipe
            // 
            this.pbTopPipe.Image = global::Weekend.Properties.Resources.pipedown;
            this.pbTopPipe.Location = new System.Drawing.Point(654, -378);
            this.pbTopPipe.Name = "pbTopPipe";
            this.pbTopPipe.Size = new System.Drawing.Size(284, 637);
            this.pbTopPipe.TabIndex = 3;
            this.pbTopPipe.TabStop = false;
            this.pbTopPipe.Click += new System.EventHandler(this.pbTopPipe_Click);
            // 
            // pbPipeDown
            // 
            this.pbPipeDown.Image = global::Weekend.Properties.Resources.pipe;
            this.pbPipeDown.Location = new System.Drawing.Point(654, 525);
            this.pbPipeDown.Name = "pbPipeDown";
            this.pbPipeDown.Size = new System.Drawing.Size(310, 609);
            this.pbPipeDown.TabIndex = 2;
            this.pbPipeDown.TabStop = false;
            // 
            // pbGround
            // 
            this.pbGround.Image = global::Weekend.Properties.Resources.ground;
            this.pbGround.Location = new System.Drawing.Point(-7, 810);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(1386, 168);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 1;
            this.pbGround.TabStop = false;
            // 
            // pbBird
            // 
            this.pbBird.Image = global::Weekend.Properties.Resources.bird;
            this.pbBird.Location = new System.Drawing.Point(69, 337);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(157, 125);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBird.TabIndex = 0;
            this.pbBird.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(1074, 35);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(179, 42);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score = 0";
            // 
            // tmrGame
            // 
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(375, 348);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(777, 51);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Druk op de Spatie toets om te beginnen";
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // FlappyBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(1369, 975);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbTopPipe);
            this.Controls.Add(this.pbPipeDown);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.pbBird);
            this.Name = "FlappyBird";
            this.Text = "FlappyBird";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.tmrGame_Tick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FlappyBird_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbTopPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.PictureBox pbPipeDown;
        private System.Windows.Forms.PictureBox pbTopPipe;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Label lblStart;
    }
}