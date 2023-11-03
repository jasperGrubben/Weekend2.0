﻿namespace Weekend.admin
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlGegevens = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTussenvoegsel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtGebruikersnaam = new System.Windows.Forms.TextBox();
            this.txtRolID = new System.Windows.Forms.TextBox();
            this.lblGebruikersNaam = new System.Windows.Forms.Label();
            this.lblRolID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDeleteConfirm = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblChangePass = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteConfirm = new System.Windows.Forms.Button();
            this.pnlGegevens.SuspendLayout();
            this.pnlDeleteConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(237, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Zoek!";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(132, 74);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zoek voor een gebruiker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "gebruikersnaam:";
            // 
            // pnlGegevens
            // 
            this.pnlGegevens.Controls.Add(this.lblChangePass);
            this.pnlGegevens.Controls.Add(this.lblResult);
            this.pnlGegevens.Controls.Add(this.label9);
            this.pnlGegevens.Controls.Add(this.btnEdit);
            this.pnlGegevens.Controls.Add(this.btnCancelUpdate);
            this.pnlGegevens.Controls.Add(this.btnDelete);
            this.pnlGegevens.Controls.Add(this.txtAchternaam);
            this.pnlGegevens.Controls.Add(this.label6);
            this.pnlGegevens.Controls.Add(this.txtTussenvoegsel);
            this.pnlGegevens.Controls.Add(this.label5);
            this.pnlGegevens.Controls.Add(this.txtVoornaam);
            this.pnlGegevens.Controls.Add(this.label4);
            this.pnlGegevens.Controls.Add(this.txtEmail);
            this.pnlGegevens.Controls.Add(this.lblEmail);
            this.pnlGegevens.Controls.Add(this.txtGebruikersnaam);
            this.pnlGegevens.Controls.Add(this.txtRolID);
            this.pnlGegevens.Controls.Add(this.lblGebruikersNaam);
            this.pnlGegevens.Controls.Add(this.lblRolID);
            this.pnlGegevens.Controls.Add(this.label3);
            this.pnlGegevens.Location = new System.Drawing.Point(406, 27);
            this.pnlGegevens.Name = "pnlGegevens";
            this.pnlGegevens.Size = new System.Drawing.Size(273, 302);
            this.pnlGegevens.TabIndex = 4;
            this.pnlGegevens.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Black;
            this.lblResult.Location = new System.Drawing.Point(138, 71);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "gegevens voor:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.ForeColor = System.Drawing.Color.Lime;
            this.btnEdit.Location = new System.Drawing.Point(178, 260);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.BackColor = System.Drawing.Color.White;
            this.btnCancelUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnCancelUpdate.Location = new System.Drawing.Point(97, 260);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnCancelUpdate.TabIndex = 16;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(16, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.BackColor = System.Drawing.Color.White;
            this.txtAchternaam.ForeColor = System.Drawing.Color.Black;
            this.txtAchternaam.Location = new System.Drawing.Point(141, 218);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(100, 22);
            this.txtAchternaam.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Achternaam:";
            // 
            // txtTussenvoegsel
            // 
            this.txtTussenvoegsel.BackColor = System.Drawing.Color.White;
            this.txtTussenvoegsel.ForeColor = System.Drawing.Color.Black;
            this.txtTussenvoegsel.Location = new System.Drawing.Point(141, 193);
            this.txtTussenvoegsel.Name = "txtTussenvoegsel";
            this.txtTussenvoegsel.Size = new System.Drawing.Size(100, 22);
            this.txtTussenvoegsel.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tussenvoegsel:";
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.BackColor = System.Drawing.Color.White;
            this.txtVoornaam.ForeColor = System.Drawing.Color.Black;
            this.txtVoornaam.Location = new System.Drawing.Point(141, 168);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(100, 22);
            this.txtVoornaam.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(30, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Voornaam:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(141, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(44, 146);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // txtGebruikersnaam
            // 
            this.txtGebruikersnaam.BackColor = System.Drawing.Color.White;
            this.txtGebruikersnaam.ForeColor = System.Drawing.Color.Black;
            this.txtGebruikersnaam.Location = new System.Drawing.Point(141, 118);
            this.txtGebruikersnaam.Name = "txtGebruikersnaam";
            this.txtGebruikersnaam.Size = new System.Drawing.Size(100, 22);
            this.txtGebruikersnaam.TabIndex = 6;
            // 
            // txtRolID
            // 
            this.txtRolID.BackColor = System.Drawing.Color.White;
            this.txtRolID.ForeColor = System.Drawing.Color.Black;
            this.txtRolID.Location = new System.Drawing.Point(141, 93);
            this.txtRolID.Name = "txtRolID";
            this.txtRolID.Size = new System.Drawing.Size(100, 22);
            this.txtRolID.TabIndex = 5;
            // 
            // lblGebruikersNaam
            // 
            this.lblGebruikersNaam.AutoSize = true;
            this.lblGebruikersNaam.ForeColor = System.Drawing.Color.Black;
            this.lblGebruikersNaam.Location = new System.Drawing.Point(13, 121);
            this.lblGebruikersNaam.Name = "lblGebruikersNaam";
            this.lblGebruikersNaam.Size = new System.Drawing.Size(110, 16);
            this.lblGebruikersNaam.TabIndex = 2;
            this.lblGebruikersNaam.Text = "Gebruikersnaam:";
            // 
            // lblRolID
            // 
            this.lblRolID.AutoSize = true;
            this.lblRolID.ForeColor = System.Drawing.Color.Black;
            this.lblRolID.Location = new System.Drawing.Point(42, 96);
            this.lblRolID.Name = "lblRolID";
            this.lblRolID.Size = new System.Drawing.Size(47, 16);
            this.lblRolID.TabIndex = 1;
            this.lblRolID.Text = "Rol ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gegevens";
            // 
            // pnlDeleteConfirm
            // 
            this.pnlDeleteConfirm.Controls.Add(this.btnDeleteConfirm);
            this.pnlDeleteConfirm.Controls.Add(this.button1);
            this.pnlDeleteConfirm.Controls.Add(this.label8);
            this.pnlDeleteConfirm.Controls.Add(this.label7);
            this.pnlDeleteConfirm.Location = new System.Drawing.Point(29, 123);
            this.pnlDeleteConfirm.Name = "pnlDeleteConfirm";
            this.pnlDeleteConfirm.Size = new System.Drawing.Size(325, 206);
            this.pnlDeleteConfirm.TabIndex = 5;
            this.pnlDeleteConfirm.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(23, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Alle gegevens van dit account gaan verloren.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(57, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 50);
            this.label7.TabIndex = 0;
            this.label7.Text = "Weet u zeker dat u \r\ndit wilt deleten?";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblChangePass
            // 
            this.lblChangePass.AutoSize = true;
            this.lblChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblChangePass.Location = new System.Drawing.Point(16, 241);
            this.lblChangePass.Name = "lblChangePass";
            this.lblChangePass.Size = new System.Drawing.Size(117, 16);
            this.lblChangePass.TabIndex = 20;
            this.lblChangePass.Text = "Change Password";
            this.lblChangePass.Click += new System.EventHandler(this.lblChangePass_OnClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(175, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 83);
            this.button1.TabIndex = 21;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnDeleteConfirm
            // 
            this.btnDeleteConfirm.BackColor = System.Drawing.Color.White;
            this.btnDeleteConfirm.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteConfirm.Location = new System.Drawing.Point(26, 111);
            this.btnDeleteConfirm.Name = "btnDeleteConfirm";
            this.btnDeleteConfirm.Size = new System.Drawing.Size(132, 83);
            this.btnDeleteConfirm.TabIndex = 21;
            this.btnDeleteConfirm.Text = "Delete";
            this.btnDeleteConfirm.UseVisualStyleBackColor = false;
            this.btnDeleteConfirm.Click += new System.EventHandler(this.btnDeleteConfirm_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 382);
            this.Controls.Add(this.pnlDeleteConfirm);
            this.Controls.Add(this.pnlGegevens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Admin Control Panel";
            this.pnlGegevens.ResumeLayout(false);
            this.pnlGegevens.PerformLayout();
            this.pnlDeleteConfirm.ResumeLayout(false);
            this.pnlDeleteConfirm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlGegevens;
        private System.Windows.Forms.Label lblGebruikersNaam;
        private System.Windows.Forms.Label lblRolID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtGebruikersnaam;
        private System.Windows.Forms.TextBox txtRolID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTussenvoegsel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Panel pnlDeleteConfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblChangePass;
        private System.Windows.Forms.Button btnDeleteConfirm;
        private System.Windows.Forms.Button button1;
    }
}