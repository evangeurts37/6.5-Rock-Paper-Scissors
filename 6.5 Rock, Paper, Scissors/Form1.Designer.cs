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
            this.btnInstructions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOpponent)).BeginInit();
            this.grpChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(41, 263);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(95, 34);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(194, 147);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 28);
            this.lblResult.TabIndex = 1;
            // 
            // lblWordWin
            // 
            this.lblWordWin.AutoSize = true;
            this.lblWordWin.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordWin.Location = new System.Drawing.Point(427, 21);
            this.lblWordWin.Name = "lblWordWin";
            this.lblWordWin.Size = new System.Drawing.Size(62, 25);
            this.lblWordWin.TabIndex = 2;
            this.lblWordWin.Text = "Wins:";
            // 
            // lblWordLose
            // 
            this.lblWordLose.AutoSize = true;
            this.lblWordLose.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordLose.Location = new System.Drawing.Point(421, 46);
            this.lblWordLose.Name = "lblWordLose";
            this.lblWordLose.Size = new System.Drawing.Size(68, 25);
            this.lblWordLose.TabIndex = 3;
            this.lblWordLose.Text = "Loses:";
            // 
            // lblWordTie
            // 
            this.lblWordTie.AutoSize = true;
            this.lblWordTie.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordTie.Location = new System.Drawing.Point(436, 71);
            this.lblWordTie.Name = "lblWordTie";
            this.lblWordTie.Size = new System.Drawing.Size(53, 25);
            this.lblWordTie.TabIndex = 4;
            this.lblWordTie.Text = "Ties:";
            // 
            // imgPlayer
            // 
            this.imgPlayer.Image = ((System.Drawing.Image)(resources.GetObject("imgPlayer.Image")));
            this.imgPlayer.Location = new System.Drawing.Point(12, 12);
            this.imgPlayer.Name = "imgPlayer";
            this.imgPlayer.Size = new System.Drawing.Size(156, 93);
            this.imgPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlayer.TabIndex = 5;
            this.imgPlayer.TabStop = false;
            // 
            // imgOpponent
            // 
            this.imgOpponent.Image = ((System.Drawing.Image)(resources.GetObject("imgOpponent.Image")));
            this.imgOpponent.Location = new System.Drawing.Point(233, 12);
            this.imgOpponent.Name = "imgOpponent";
            this.imgOpponent.Size = new System.Drawing.Size(158, 93);
            this.imgOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOpponent.TabIndex = 6;
            this.imgOpponent.TabStop = false;
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Location = new System.Drawing.Point(6, 19);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(65, 25);
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
            this.radPaper.Size = new System.Drawing.Size(72, 25);
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
            this.radScissors.Size = new System.Drawing.Size(86, 25);
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
            this.grpChoice.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChoice.Location = new System.Drawing.Point(12, 128);
            this.grpChoice.Name = "grpChoice";
            this.grpChoice.Size = new System.Drawing.Size(156, 100);
            this.grpChoice.TabIndex = 10;
            this.grpChoice.TabStop = false;
            this.grpChoice.Text = "Pick One";
            // 
            // lblWins
            // 
            this.lblWins.AutoSize = true;
            this.lblWins.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWins.Location = new System.Drawing.Point(482, 21);
            this.lblWins.Name = "lblWins";
            this.lblWins.Size = new System.Drawing.Size(23, 25);
            this.lblWins.TabIndex = 11;
            this.lblWins.Text = "0";
            // 
            // lblLoses
            // 
            this.lblLoses.AutoSize = true;
            this.lblLoses.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoses.Location = new System.Drawing.Point(482, 46);
            this.lblLoses.Name = "lblLoses";
            this.lblLoses.Size = new System.Drawing.Size(23, 25);
            this.lblLoses.TabIndex = 12;
            this.lblLoses.Text = "0";
            // 
            // lblTies
            // 
            this.lblTies.AutoSize = true;
            this.lblTies.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTies.Location = new System.Drawing.Point(482, 71);
            this.lblTies.Name = "lblTies";
            this.lblTies.Size = new System.Drawing.Size(23, 25);
            this.lblTies.TabIndex = 13;
            this.lblTies.Text = "0";
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.Violet;
            this.btnInstructions.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.Location = new System.Drawing.Point(169, 263);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(105, 34);
            this.btnInstructions.TabIndex = 14;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // FormRPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(508, 303);
            this.Controls.Add(this.btnInstructions);
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
        private System.Windows.Forms.Button btnInstructions;
    }
}

