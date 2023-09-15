namespace Weekend.docent
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAGOnummer = new System.Windows.Forms.Label();
            this.lblALInummer = new System.Windows.Forms.Label();
            this.lblALI = new System.Windows.Forms.Label();
            this.lblAGO = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.leerlingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klassenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLeerling = new System.Windows.Forms.Panel();
            this.lblLaatstIngelogd = new System.Windows.Forms.Label();
            this.lblLeerling = new System.Windows.Forms.Label();
            this.lblLaatsteOpdracht = new System.Windows.Forms.Label();
            this.pnlKlassen = new System.Windows.Forms.Panel();
            this.lblLeerling2 = new System.Windows.Forms.Label();
            this.lblKlas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlLeerling.SuspendLayout();
            this.pnlKlassen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAGOnummer);
            this.panel1.Controls.Add(this.lblALInummer);
            this.panel1.Controls.Add(this.lblALI);
            this.panel1.Controls.Add(this.lblAGO);
            this.panel1.Location = new System.Drawing.Point(142, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 408);
            this.panel1.TabIndex = 0;
            // 
            // lblAGOnummer
            // 
            this.lblAGOnummer.AutoSize = true;
            this.lblAGOnummer.Location = new System.Drawing.Point(224, 69);
            this.lblAGOnummer.Name = "lblAGOnummer";
            this.lblAGOnummer.Size = new System.Drawing.Size(16, 16);
            this.lblAGOnummer.TabIndex = 3;
            this.lblAGOnummer.Text = "...";
            // 
            // lblALInummer
            // 
            this.lblALInummer.AutoSize = true;
            this.lblALInummer.Location = new System.Drawing.Point(207, 114);
            this.lblALInummer.Name = "lblALInummer";
            this.lblALInummer.Size = new System.Drawing.Size(16, 16);
            this.lblALInummer.TabIndex = 2;
            this.lblALInummer.Text = "...";
            // 
            // lblALI
            // 
            this.lblALI.AutoSize = true;
            this.lblALI.Location = new System.Drawing.Point(35, 114);
            this.lblALI.Name = "lblALI";
            this.lblALI.Size = new System.Drawing.Size(166, 16);
            this.lblALI.TabIndex = 1;
            this.lblALI.Text = "Aantal leerlingen ingelogd:";
            // 
            // lblAGO
            // 
            this.lblAGO.AutoSize = true;
            this.lblAGO.Location = new System.Drawing.Point(35, 69);
            this.lblAGO.Name = "lblAGO";
            this.lblAGO.Size = new System.Drawing.Size(183, 16);
            this.lblAGO.TabIndex = 0;
            this.lblAGO.Text = "Aantal gemaakte opdrachten:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leerlingToolStripMenuItem,
            this.klassenToolStripMenuItem,
            this.gamesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(989, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // leerlingToolStripMenuItem
            // 
            this.leerlingToolStripMenuItem.Name = "leerlingToolStripMenuItem";
            this.leerlingToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.leerlingToolStripMenuItem.Text = "leerling";
            this.leerlingToolStripMenuItem.Click += new System.EventHandler(this.leerlingToolStripMenuItem_Click);
            // 
            // klassenToolStripMenuItem
            // 
            this.klassenToolStripMenuItem.Name = "klassenToolStripMenuItem";
            this.klassenToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.klassenToolStripMenuItem.Text = "klassen";
            this.klassenToolStripMenuItem.Click += new System.EventHandler(this.klassenToolStripMenuItem_Click);
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.gamesToolStripMenuItem.Text = "games";
            this.gamesToolStripMenuItem.Click += new System.EventHandler(this.gamesToolStripMenuItem_Click);
            // 
            // pnlLeerling
            // 
            this.pnlLeerling.Controls.Add(this.lblLaatsteOpdracht);
            this.pnlLeerling.Controls.Add(this.lblLeerling);
            this.pnlLeerling.Controls.Add(this.lblLaatstIngelogd);
            this.pnlLeerling.Location = new System.Drawing.Point(46, 94);
            this.pnlLeerling.Name = "pnlLeerling";
            this.pnlLeerling.Size = new System.Drawing.Size(829, 347);
            this.pnlLeerling.TabIndex = 5;
            this.pnlLeerling.Visible = false;
            // 
            // lblLaatstIngelogd
            // 
            this.lblLaatstIngelogd.AutoSize = true;
            this.lblLaatstIngelogd.Location = new System.Drawing.Point(339, 18);
            this.lblLaatstIngelogd.Name = "lblLaatstIngelogd";
            this.lblLaatstIngelogd.Size = new System.Drawing.Size(95, 16);
            this.lblLaatstIngelogd.TabIndex = 2;
            this.lblLaatstIngelogd.Text = "laatst ingelogd";
            // 
            // lblLeerling
            // 
            this.lblLeerling.AutoSize = true;
            this.lblLeerling.Location = new System.Drawing.Point(45, 18);
            this.lblLeerling.Name = "lblLeerling";
            this.lblLeerling.Size = new System.Drawing.Size(51, 16);
            this.lblLeerling.TabIndex = 1;
            this.lblLeerling.Text = "leerling";
            // 
            // lblLaatsteOpdracht
            // 
            this.lblLaatsteOpdracht.AutoSize = true;
            this.lblLaatsteOpdracht.Location = new System.Drawing.Point(640, 18);
            this.lblLaatsteOpdracht.Name = "lblLaatsteOpdracht";
            this.lblLaatsteOpdracht.Size = new System.Drawing.Size(103, 16);
            this.lblLaatsteOpdracht.TabIndex = 3;
            this.lblLaatsteOpdracht.Text = "laatste opdracht";
            // 
            // pnlKlassen
            // 
            this.pnlKlassen.Controls.Add(this.lblLeerling2);
            this.pnlKlassen.Controls.Add(this.lblKlas);
            this.pnlKlassen.Controls.Add(this.label3);
            this.pnlKlassen.Location = new System.Drawing.Point(87, 31);
            this.pnlKlassen.Name = "pnlKlassen";
            this.pnlKlassen.Size = new System.Drawing.Size(890, 413);
            this.pnlKlassen.TabIndex = 4;
            this.pnlKlassen.Visible = false;
            // 
            // lblLeerling2
            // 
            this.lblLeerling2.AutoSize = true;
            this.lblLeerling2.Location = new System.Drawing.Point(52, 28);
            this.lblLeerling2.Name = "lblLeerling2";
            this.lblLeerling2.Size = new System.Drawing.Size(51, 16);
            this.lblLeerling2.TabIndex = 5;
            this.lblLeerling2.Text = "leerling";
            // 
            // lblKlas
            // 
            this.lblKlas.AutoSize = true;
            this.lblKlas.Location = new System.Drawing.Point(345, 28);
            this.lblKlas.Name = "lblKlas";
            this.lblKlas.Size = new System.Drawing.Size(32, 16);
            this.lblKlas.TabIndex = 6;
            this.lblKlas.Text = "klas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "......fjda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 508);
            this.Controls.Add(this.pnlKlassen);
            this.Controls.Add(this.pnlLeerling);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlLeerling.ResumeLayout(false);
            this.pnlLeerling.PerformLayout();
            this.pnlKlassen.ResumeLayout(false);
            this.pnlKlassen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAGO;
        private System.Windows.Forms.Label lblAGOnummer;
        private System.Windows.Forms.Label lblALInummer;
        private System.Windows.Forms.Label lblALI;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem leerlingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klassenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.Panel pnlLeerling;
        private System.Windows.Forms.Label lblLaatsteOpdracht;
        private System.Windows.Forms.Label lblLeerling;
        private System.Windows.Forms.Label lblLaatstIngelogd;
        private System.Windows.Forms.Panel pnlKlassen;
        private System.Windows.Forms.Label lblLeerling2;
        private System.Windows.Forms.Label lblKlas;
        private System.Windows.Forms.Label label3;
    }
    }
