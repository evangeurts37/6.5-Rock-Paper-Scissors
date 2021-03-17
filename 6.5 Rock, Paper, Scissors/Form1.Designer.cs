namespace _6._5_Rock__Paper__Scissors
{
    partial class FormRPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRPS));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblWordWin = new System.Windows.Forms.Label();
            this.lblWordLose = new System.Windows.Forms.Label();
            this.lblWordTie = new System.Windows.Forms.Label();
            this.imgPlayer = new System.Windows.Forms.PictureBox();
            this.imgOpponent = new System.Windows.Forms.PictureBox();
            this.radRock = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.grpChoice = new System.Windows.Forms.GroupBox();
            this.lblWins = new System.Windows.Forms.Label();
            this.lblLoses = new System.Windows.Forms.Label();
            this.lblTies = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            this.grpChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(107, 390);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(330, 269);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 1;
            // 
            // lblWordWin
            // 
            this.lblWordWin.AutoSize = true;
            this.lblWordWin.Location = new System.Drawing.Point(532, 19);
            this.lblWordWin.Name = "lblWordWin";
            this.lblWordWin.Size = new System.Drawing.Size(34, 13);
            this.lblWordWin.TabIndex = 2;
            this.lblWordWin.Text = "Wins:";
            // 
            // lblWordLose
            // 
            this.lblWordLose.AutoSize = true;
            this.lblWordLose.Location = new System.Drawing.Point(532, 41);
            this.lblWordLose.Name = "lblWordLose";
            this.lblWordLose.Size = new System.Drawing.Size(38, 13);
            this.lblWordLose.TabIndex = 3;
            this.lblWordLose.Text = "Loses:";
            // 
            // lblWordTie
            // 
            this.lblWordTie.AutoSize = true;
            this.lblWordTie.Location = new System.Drawing.Point(532, 64);
            this.lblWordTie.Name = "lblWordTie";
            this.lblWordTie.Size = new System.Drawing.Size(30, 13);
            this.lblWordTie.TabIndex = 4;
            this.lblWordTie.Text = "Ties:";
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = ((System.Drawing.Image)(resources.GetObject("imgPlayer.Image")));
            this.imgPlayer.Location = new System.Drawing.Point(94, 118);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(100, 50);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 5;
            this.imgPlayer.TabStop = false;
            // 
            // imgOpponent
            // 
            this.imgOpponent.Image = ((System.Drawing.Image)(resources.GetObject("imgOpponent.Image")));
            this.imgOpponent.Location = new System.Drawing.Point(318, 118);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(100, 50);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 6;
            this.imgOpponent.TabStop = false;
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Location = new System.Drawing.Point(6, 19);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(51, 17);
            this.radRock.TabIndex = 7;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            this.radRock.CheckedChanged += new System.EventHandler(this.radRock_CheckedChanged);
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Location = new System.Drawing.Point(6, 42);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(53, 17);
            this.radPaper.TabIndex = 8;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            this.radPaper.CheckedChanged += new System.EventHandler(this.radPaper_CheckedChanged);
            // 
            // radScissors
            // 
            this.radScissors.AutoSize = true;
            this.radScissors.Location = new System.Drawing.Point(6, 65);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(64, 17);
            this.radScissors.TabIndex = 9;
            this.radScissors.TabStop = true;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = true;
            this.radScissors.CheckedChanged += new System.EventHandler(this.radScissors_CheckedChanged);
            // 
            // grpChoice
            // 
            this.grpChoice.Controls.Add(this.radRock);
            this.grpChoice.Controls.Add(this.radScissors);
            this.grpChoice.Controls.Add(this.radPaper);
            this.grpChoice.Location = new System.Drawing.Point(50, 246);
            this.grpChoice.Name = "grpChoice";
            this.grpChoice.Size = new System.Drawing.Size(200, 100);
            this.grpChoice.TabIndex = 10;
            this.grpChoice.TabStop = false;
            this.grpChoice.Text = "Pick One";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Location = new System.Drawing.Point(572, 19);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(13, 13);
            this.lblWins.TabIndex = 11;
            this.lblWins.Text = "0";
            // 
            // lblLoses
            // 
            this.lblLoses.AutoSize = true;
            this.lblLoses.Location = new System.Drawing.Point(574, 41);
            this.lblLoses.Name = "lblLoses";
            this.lblLoses.Size = new System.Drawing.Size(13, 13);
            this.lblLoses.TabIndex = 12;
            this.lblLoses.Text = "0";
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.Location = new System.Drawing.Point(574, 64);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(13, 13);
            this.lblTies.TabIndex = 13;
            this.lblTies.Text = "0";
            // 
            // FormRPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTies);
            this.Controls.Add(this.lblLoses);
            this.Controls.Add(this.lblWins);
            this.Controls.Add(this.grpChoice);
            this.Controls.Add(this.imgOpponent);
            this.Controls.Add(this.imgPlayer);
            this.Controls.Add(this.lblWordTie);
            this.Controls.Add(this.lblWordLose);
            this.Controls.Add(this.lblWordWin);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSubmit);
            this.Name = "FormRPS";
            this.Text = "Rock, Paper, Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).EndInit();
            this.grpChoice.ResumeLayout(false);
            this.grpChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblWordWin;
        private System.Windows.Forms.Label lblWordLose;
        private System.Windows.Forms.Label lblWordTie;
        private System.Windows.Forms.PictureBox imgPlayer;
        private System.Windows.Forms.PictureBox imgOpponent;
        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.GroupBox grpChoice;
        private System.Windows.Forms.Label lblWins;
        private System.Windows.Forms.Label lblLoses;
        private System.Windows.Forms.Label lblTies;
    }
}

