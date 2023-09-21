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
            this.lblLaatsteOpdracht = new System.Windows.Forms.Label();
            this.lblLeerling = new System.Windows.Forms.Label();
            this.lblLaatstIngelogd = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(213, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 638);
            this.panel1.TabIndex = 0;
            // 
            // lblAGOnummer
            // 
            this.lblAGOnummer.AutoSize = true;
            this.lblAGOnummer.Location = new System.Drawing.Point(336, 108);
            this.lblAGOnummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAGOnummer.Name = "lblAGOnummer";
            this.lblAGOnummer.Size = new System.Drawing.Size(30, 25);
            this.lblAGOnummer.TabIndex = 3;
            this.lblAGOnummer.Text = "...";
            // 
            // lblALInummer
            // 
            this.lblALInummer.AutoSize = true;
            this.lblALInummer.Location = new System.Drawing.Point(310, 178);
            this.lblALInummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblALInummer.Name = "lblALInummer";
            this.lblALInummer.Size = new System.Drawing.Size(30, 25);
            this.lblALInummer.TabIndex = 2;
            this.lblALInummer.Text = "...";
            // 
            // lblALI
            // 
            this.lblALI.AutoSize = true;
            this.lblALI.Location = new System.Drawing.Point(52, 178);
            this.lblALI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblALI.Name = "lblALI";
            this.lblALI.Size = new System.Drawing.Size(267, 25);
            this.lblALI.TabIndex = 1;
            this.lblALI.Text = "Aantal leerlingen ingelogd:";
            // 
            // lblAGO
            // 
            this.lblAGO.AutoSize = true;
            this.lblAGO.Location = new System.Drawing.Point(52, 108);
            this.lblAGO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAGO.Name = "lblAGO";
            this.lblAGO.Size = new System.Drawing.Size(293, 25);
            this.lblAGO.TabIndex = 0;
            this.lblAGO.Text = "Aantal gemaakte opdrachten:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leerlingToolStripMenuItem,
            this.klassenToolStripMenuItem,
            this.gamesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1484, 42);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // leerlingToolStripMenuItem
            // 
            this.leerlingToolStripMenuItem.Name = "leerlingToolStripMenuItem";
            this.leerlingToolStripMenuItem.Size = new System.Drawing.Size(114, 36);
            this.leerlingToolStripMenuItem.Text = "leerling";
            this.leerlingToolStripMenuItem.Click += new System.EventHandler(this.leerlingToolStripMenuItem_Click);
            // 
            // klassenToolStripMenuItem
            // 
            this.klassenToolStripMenuItem.Name = "klassenToolStripMenuItem";
            this.klassenToolStripMenuItem.Size = new System.Drawing.Size(111, 36);
            this.klassenToolStripMenuItem.Text = "klassen";
            this.klassenToolStripMenuItem.Click += new System.EventHandler(this.klassenToolStripMenuItem_Click);
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(104, 36);
            this.gamesToolStripMenuItem.Text = "games";
            this.gamesToolStripMenuItem.Click += new System.EventHandler(this.gamesToolStripMenuItem_Click);
            // 
            // pnlLeerling
            // 
            this.pnlLeerling.Controls.Add(this.lblLaatsteOpdracht);
            this.pnlLeerling.Controls.Add(this.lblLeerling);
            this.pnlLeerling.Controls.Add(this.lblLaatstIngelogd);
            this.pnlLeerling.Location = new System.Drawing.Point(69, 147);
            this.pnlLeerling.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlLeerling.Name = "pnlLeerling";
            this.pnlLeerling.Size = new System.Drawing.Size(1244, 542);
            this.pnlLeerling.TabIndex = 5;
            this.pnlLeerling.Visible = false;
            // 
            // lblLaatsteOpdracht
            // 
            this.lblLaatsteOpdracht.AutoSize = true;
            this.lblLaatsteOpdracht.Location = new System.Drawing.Point(960, 28);
            this.lblLaatsteOpdracht.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLaatsteOpdracht.Name = "lblLaatsteOpdracht";
            this.lblLaatsteOpdracht.Size = new System.Drawing.Size(166, 25);
            this.lblLaatsteOpdracht.TabIndex = 3;
            this.lblLaatsteOpdracht.Text = "laatste opdracht";
            // 
            // lblLeerling
            // 
            this.lblLeerling.AutoSize = true;
            this.lblLeerling.Location = new System.Drawing.Point(68, 28);
            this.lblLeerling.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeerling.Name = "lblLeerling";
            this.lblLeerling.Size = new System.Drawing.Size(82, 25);
            this.lblLeerling.TabIndex = 1;
            this.lblLeerling.Text = "leerling";
            // 
            // lblLaatstIngelogd
            // 
            this.lblLaatstIngelogd.AutoSize = true;
            this.lblLaatstIngelogd.Location = new System.Drawing.Point(508, 28);
            this.lblLaatstIngelogd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLaatstIngelogd.Name = "lblLaatstIngelogd";
            this.lblLaatstIngelogd.Size = new System.Drawing.Size(152, 25);
            this.lblLaatstIngelogd.TabIndex = 2;
            this.lblLaatstIngelogd.Text = "laatst ingelogd";
            // 
            // pnlKlassen
            // 
            this.pnlKlassen.Controls.Add(this.lblLeerling2);
            this.pnlKlassen.Controls.Add(this.lblKlas);
            this.pnlKlassen.Controls.Add(this.label3);
            this.pnlKlassen.Location = new System.Drawing.Point(130, 48);
            this.pnlKlassen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlKlassen.Name = "pnlKlassen";
            this.pnlKlassen.Size = new System.Drawing.Size(1335, 645);
            this.pnlKlassen.TabIndex = 4;
            this.pnlKlassen.Visible = false;
            // 
            // lblLeerling2
            // 
            this.lblLeerling2.AutoSize = true;
            this.lblLeerling2.Location = new System.Drawing.Point(78, 44);
            this.lblLeerling2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeerling2.Name = "lblLeerling2";
            this.lblLeerling2.Size = new System.Drawing.Size(82, 25);
            this.lblLeerling2.TabIndex = 5;
            this.lblLeerling2.Text = "leerling";
            // 
            // lblKlas
            // 
            this.lblKlas.AutoSize = true;
            this.lblKlas.Location = new System.Drawing.Point(518, 44);
            this.lblKlas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKlas.Name = "lblKlas";
            this.lblKlas.Size = new System.Drawing.Size(51, 25);
            this.lblKlas.TabIndex = 6;
            this.lblKlas.Text = "klas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(940, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "......fjda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 794);
            this.Controls.Add(this.pnlKlassen);
            this.Controls.Add(this.pnlLeerling);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
