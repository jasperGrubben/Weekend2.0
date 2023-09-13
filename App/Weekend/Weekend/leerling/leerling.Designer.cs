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
            this.label5 = new System.Windows.Forms.Label();
            this.pnlHighS = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlOpdrachten = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblconnection = new System.Windows.Forms.Label();
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
            this.pnlScores.Controls.Add(this.label5);
            this.pnlScores.Location = new System.Drawing.Point(992, 110);
            this.pnlScores.Name = "pnlScores";
            this.pnlScores.Size = new System.Drawing.Size(580, 688);
            this.pnlScores.TabIndex = 6;
            this.pnlScores.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // pnlHighS
            // 
            this.pnlHighS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHighS.Controls.Add(this.label4);
            this.pnlHighS.Controls.Add(this.pnlOpdrachten);
            this.pnlHighS.Location = new System.Drawing.Point(1843, 22);
            this.pnlHighS.Name = "pnlHighS";
            this.pnlHighS.Size = new System.Drawing.Size(561, 657);
            this.pnlHighS.TabIndex = 7;
            this.pnlHighS.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // pnlOpdrachten
            // 
            this.pnlOpdrachten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOpdrachten.Controls.Add(this.label6);
            this.pnlOpdrachten.Location = new System.Drawing.Point(-1, 492);
            this.pnlOpdrachten.Name = "pnlOpdrachten";
            this.pnlOpdrachten.Size = new System.Drawing.Size(561, 657);
            this.pnlOpdrachten.TabIndex = 8;
            this.pnlOpdrachten.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // lblconnection
            // 
            this.lblconnection.AutoSize = true;
            this.lblconnection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblconnection.Location = new System.Drawing.Point(421, 809);
            this.lblconnection.Name = "lblconnection";
            this.lblconnection.Size = new System.Drawing.Size(2, 27);
            this.lblconnection.TabIndex = 9;
            this.lblconnection.Click += new System.EventHandler(this.lblconnection_Click);
            // 
            // leerling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2039, 1088);
            this.Controls.Add(this.lblconnection);
            this.Controls.Add(this.pnlHighS);
            this.Controls.Add(this.pnlScores);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWelkom);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "leerling";
            this.Text = "leerling";
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlHighS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlOpdrachten;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblconnection;
    }
}