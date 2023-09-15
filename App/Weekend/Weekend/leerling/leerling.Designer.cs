namespace Weekend.leerling
{
    partial class leerling
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.scoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opdrachtenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelkom = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.pnlScores = new System.Windows.Forms.Panel();
            this.lblScores = new System.Windows.Forms.Label();
            this.pnlHighS = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.lblHighScoresHead = new System.Windows.Forms.Label();
            this.pnlOpdrachten = new System.Windows.Forms.Panel();
            this.btnOpdracht3 = new System.Windows.Forms.Button();
            this.btnOpdracht2 = new System.Windows.Forms.Button();
            this.btnOpdr1 = new System.Windows.Forms.Button();
            this.lblOpdrachtenHead = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlScores.SuspendLayout();
            this.pnlHighS.SuspendLayout();
            this.pnlOpdrachten.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scoresToolStripMenuItem,
            this.highScoresToolStripMenuItem,
            this.opdrachtenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2039, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // scoresToolStripMenuItem
            // 
            this.scoresToolStripMenuItem.Name = "scoresToolStripMenuItem";
            this.scoresToolStripMenuItem.Size = new System.Drawing.Size(100, 36);
            this.scoresToolStripMenuItem.Text = "scores";
            this.scoresToolStripMenuItem.Click += new System.EventHandler(this.scoresToolStripMenuItem_Click);
            // 
            // highScoresToolStripMenuItem
            // 
            this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
            this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(161, 36);
            this.highScoresToolStripMenuItem.Text = "High Scores";
            this.highScoresToolStripMenuItem.Click += new System.EventHandler(this.highScoresToolStripMenuItem_Click);
            // 
            // opdrachtenToolStripMenuItem
            // 
            this.opdrachtenToolStripMenuItem.Name = "opdrachtenToolStripMenuItem";
            this.opdrachtenToolStripMenuItem.Size = new System.Drawing.Size(156, 36);
            this.opdrachtenToolStripMenuItem.Text = "opdrachten";
            this.opdrachtenToolStripMenuItem.Click += new System.EventHandler(this.opdrachtenToolStripMenuItem_Click);
            // 
            // lblWelkom
            // 
            this.lblWelkom.AutoSize = true;
            this.lblWelkom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelkom.Location = new System.Drawing.Point(66, 150);
            this.lblWelkom.Name = "lblWelkom";
            this.lblWelkom.Size = new System.Drawing.Size(210, 55);
            this.lblWelkom.TabIndex = 2;
            this.lblWelkom.Text = "Welkom,";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sussy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 55);
            this.label2.TabIndex = 4;
            this.label2.Text = "Het is vandaag de:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(522, 228);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(166, 55);
            this.lblDatum.TabIndex = 5;
            this.lblDatum.Text = "Datum";
            // 
            // pnl
            // 
            this.pnl.Location = new System.Drawing.Point(1059, 476);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1516, 667);
            this.pnl.TabIndex = 7;
            this.pnl.Visible = false;
            // 
            // pnlScores
            // 
            this.pnlScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlScores.Controls.Add(this.lblScores);
            this.pnlScores.Location = new System.Drawing.Point(1780, 768);
            this.pnlScores.Name = "pnlScores";
            this.pnlScores.Size = new System.Drawing.Size(639, 794);
            this.pnlScores.TabIndex = 6;
            this.pnlScores.Visible = false;
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScores.Location = new System.Drawing.Point(20, 18);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(157, 51);
            this.lblScores.TabIndex = 10;
            this.lblScores.Text = "Scores";
            // 
            // pnlHighS
            // 
            this.pnlHighS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHighS.Controls.Add(this.label4);
            this.pnlHighS.Controls.Add(this.txtScore);
            this.pnlHighS.Controls.Add(this.label3);
            this.pnlHighS.Controls.Add(this.txtNaam);
            this.pnlHighS.Controls.Add(this.lblHighScoresHead);
            this.pnlHighS.Location = new System.Drawing.Point(497, 78);
            this.pnlHighS.Name = "pnlHighS";
            this.pnlHighS.Size = new System.Drawing.Size(1157, 842);
            this.pnlHighS.TabIndex = 7;
            this.pnlHighS.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Score";
            // 
            // txtScore
            // 
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScore.Location = new System.Drawing.Point(335, 148);
            this.txtScore.Multiline = true;
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(242, 606);
            this.txtScore.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "wie?";
            // 
            // txtNaam
            // 
            this.txtNaam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNaam.Location = new System.Drawing.Point(34, 148);
            this.txtNaam.Multiline = true;
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.ReadOnly = true;
            this.txtNaam.Size = new System.Drawing.Size(242, 606);
            this.txtNaam.TabIndex = 1;
            this.txtNaam.TextChanged += new System.EventHandler(this.txtNaam_TextChanged);
            // 
            // lblHighScoresHead
            // 
            this.lblHighScoresHead.AutoSize = true;
            this.lblHighScoresHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScoresHead.Location = new System.Drawing.Point(34, 43);
            this.lblHighScoresHead.Name = "lblHighScoresHead";
            this.lblHighScoresHead.Size = new System.Drawing.Size(257, 51);
            this.lblHighScoresHead.TabIndex = 0;
            this.lblHighScoresHead.Text = "High Scores";
            // 
            // pnlOpdrachten
            // 
            this.pnlOpdrachten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpdrachten.Controls.Add(this.btnOpdracht3);
            this.pnlOpdrachten.Controls.Add(this.btnOpdracht2);
            this.pnlOpdrachten.Controls.Add(this.btnOpdr1);
            this.pnlOpdrachten.Controls.Add(this.lblOpdrachtenHead);
            this.pnlOpdrachten.Location = new System.Drawing.Point(25, 78);
            this.pnlOpdrachten.Name = "pnlOpdrachten";
            this.pnlOpdrachten.Size = new System.Drawing.Size(1957, 908);
            this.pnlOpdrachten.TabIndex = 8;
            this.pnlOpdrachten.Visible = false;
            // 
            // btnOpdracht3
            // 
            this.btnOpdracht3.Location = new System.Drawing.Point(33, 326);
            this.btnOpdracht3.Name = "btnOpdracht3";
            this.btnOpdracht3.Size = new System.Drawing.Size(238, 80);
            this.btnOpdracht3.TabIndex = 10;
            this.btnOpdracht3.Text = "Opdracht3";
            this.btnOpdracht3.UseVisualStyleBackColor = true;
            // 
            // btnOpdracht2
            // 
            this.btnOpdracht2.Location = new System.Drawing.Point(33, 224);
            this.btnOpdracht2.Name = "btnOpdracht2";
            this.btnOpdracht2.Size = new System.Drawing.Size(238, 80);
            this.btnOpdracht2.TabIndex = 9;
            this.btnOpdracht2.Text = "Opdracht2";
            this.btnOpdracht2.UseVisualStyleBackColor = true;
            // 
            // btnOpdr1
            // 
            this.btnOpdr1.Location = new System.Drawing.Point(33, 122);
            this.btnOpdr1.Name = "btnOpdr1";
            this.btnOpdr1.Size = new System.Drawing.Size(241, 82);
            this.btnOpdr1.TabIndex = 2;
            this.btnOpdr1.Text = "Opdracht 1";
            this.btnOpdr1.UseVisualStyleBackColor = true;
            this.btnOpdr1.Click += new System.EventHandler(this.btnOpdr1_Click);
            // 
            // lblOpdrachtenHead
            // 
            this.lblOpdrachtenHead.AutoSize = true;
            this.lblOpdrachtenHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpdrachtenHead.Location = new System.Drawing.Point(24, 29);
            this.lblOpdrachtenHead.Name = "lblOpdrachtenHead";
            this.lblOpdrachtenHead.Size = new System.Drawing.Size(247, 51);
            this.lblOpdrachtenHead.TabIndex = 1;
            this.lblOpdrachtenHead.Text = "Opdrachten";
            // 
            // leerling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2039, 1088);
            this.Controls.Add(this.pnlHighS);
            this.Controls.Add(this.pnlOpdrachten);
            this.Controls.Add(this.pnlScores);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelkom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "leerling";
            this.Text = "leerling";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.leerling_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlScores.ResumeLayout(false);
            this.pnlScores.PerformLayout();
            this.pnlHighS.ResumeLayout(false);
            this.pnlHighS.PerformLayout();
            this.pnlOpdrachten.ResumeLayout(false);
            this.pnlOpdrachten.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem scoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highScoresToolStripMenuItem;
        private System.Windows.Forms.Label lblWelkom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.ToolStripMenuItem opdrachtenToolStripMenuItem;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Panel pnlScores;
        private System.Windows.Forms.Panel pnlHighS;
        private System.Windows.Forms.Panel pnlOpdrachten;
        private System.Windows.Forms.Label lblOpdrachtenHead;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.Label lblHighScoresHead;
        private System.Windows.Forms.Button btnOpdr1;
        private System.Windows.Forms.Button btnOpdracht2;
        private System.Windows.Forms.Button btnOpdracht3;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label label4;
    }
}