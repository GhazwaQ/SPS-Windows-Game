namespace SPS_Windows_Game
{
    partial class frmSPSGame
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
            this.gboxUserChoice = new System.Windows.Forms.GroupBox();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.rbnStone = new System.Windows.Forms.RadioButton();
            this.rbnPaper = new System.Windows.Forms.RadioButton();
            this.rbnScissors = new System.Windows.Forms.RadioButton();
            this.gboxCompChoice = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pbxComputer = new System.Windows.Forms.PictureBox();
            this.gboxResult = new System.Windows.Forms.GroupBox();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.gboxUserChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.gboxCompChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxComputer)).BeginInit();
            this.gboxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxUserChoice
            // 
            this.gboxUserChoice.Controls.Add(this.pbxUser);
            this.gboxUserChoice.Controls.Add(this.rbnStone);
            this.gboxUserChoice.Controls.Add(this.rbnPaper);
            this.gboxUserChoice.Controls.Add(this.rbnScissors);
            this.gboxUserChoice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxUserChoice.Location = new System.Drawing.Point(12, 21);
            this.gboxUserChoice.Name = "gboxUserChoice";
            this.gboxUserChoice.Size = new System.Drawing.Size(200, 428);
            this.gboxUserChoice.TabIndex = 0;
            this.gboxUserChoice.TabStop = false;
            this.gboxUserChoice.Text = "User Choice";
            // 
            // pbxUser
            // 
            this.pbxUser.Location = new System.Drawing.Point(19, 25);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(161, 156);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUser.TabIndex = 3;
            this.pbxUser.TabStop = false;
            // 
            // rbnStone
            // 
            this.rbnStone.AutoSize = true;
            this.rbnStone.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.rbnStone.Location = new System.Drawing.Point(37, 279);
            this.rbnStone.Name = "rbnStone";
            this.rbnStone.Size = new System.Drawing.Size(72, 26);
            this.rbnStone.TabIndex = 2;
            this.rbnStone.Text = "Stone";
            this.rbnStone.UseVisualStyleBackColor = true;
            this.rbnStone.CheckedChanged += new System.EventHandler(this.rbnStone_CheckedChanged);
            // 
            // rbnPaper
            // 
            this.rbnPaper.AutoSize = true;
            this.rbnPaper.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnPaper.Location = new System.Drawing.Point(38, 249);
            this.rbnPaper.Name = "rbnPaper";
            this.rbnPaper.Size = new System.Drawing.Size(75, 26);
            this.rbnPaper.TabIndex = 1;
            this.rbnPaper.Text = "Paper";
            this.rbnPaper.UseVisualStyleBackColor = true;
            this.rbnPaper.CheckedChanged += new System.EventHandler(this.rbnPaper_CheckedChanged);
            // 
            // rbnScissors
            // 
            this.rbnScissors.AutoSize = true;
            this.rbnScissors.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnScissors.Location = new System.Drawing.Point(38, 219);
            this.rbnScissors.Name = "rbnScissors";
            this.rbnScissors.Size = new System.Drawing.Size(90, 26);
            this.rbnScissors.TabIndex = 0;
            this.rbnScissors.Text = "Scissors";
            this.rbnScissors.UseVisualStyleBackColor = true;
            this.rbnScissors.CheckedChanged += new System.EventHandler(this.rbnScissors_CheckedChanged);
            // 
            // gboxCompChoice
            // 
            this.gboxCompChoice.Controls.Add(this.btnPlay);
            this.gboxCompChoice.Controls.Add(this.pbxComputer);
            this.gboxCompChoice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.gboxCompChoice.Location = new System.Drawing.Point(236, 21);
            this.gboxCompChoice.Name = "gboxCompChoice";
            this.gboxCompChoice.Size = new System.Drawing.Size(200, 428);
            this.gboxCompChoice.TabIndex = 1;
            this.gboxCompChoice.TabStop = false;
            this.gboxCompChoice.Text = "Computer Choice";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(66, 241);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 32);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pbxComputer
            // 
            this.pbxComputer.Location = new System.Drawing.Point(15, 25);
            this.pbxComputer.Name = "pbxComputer";
            this.pbxComputer.Size = new System.Drawing.Size(161, 156);
            this.pbxComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxComputer.TabIndex = 0;
            this.pbxComputer.TabStop = false;
            // 
            // gboxResult
            // 
            this.gboxResult.Controls.Add(this.lblComputerScore);
            this.gboxResult.Controls.Add(this.lblUserScore);
            this.gboxResult.Controls.Add(this.lblResult);
            this.gboxResult.Controls.Add(this.btnQuit);
            this.gboxResult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.gboxResult.Location = new System.Drawing.Point(452, 21);
            this.gboxResult.Name = "gboxResult";
            this.gboxResult.Size = new System.Drawing.Size(200, 428);
            this.gboxResult.TabIndex = 2;
            this.gboxResult.TabStop = false;
            this.gboxResult.Text = "Result";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblComputerScore.Location = new System.Drawing.Point(21, 134);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(161, 47);
            this.lblComputerScore.TabIndex = 3;
            // 
            // lblUserScore
            // 
            this.lblUserScore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserScore.Location = new System.Drawing.Point(21, 79);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(161, 47);
            this.lblUserScore.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(17, 25);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(165, 27);
            this.lblResult.TabIndex = 1;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(65, 241);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 32);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmSPSGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(664, 346);
            this.Controls.Add(this.gboxResult);
            this.Controls.Add(this.gboxCompChoice);
            this.Controls.Add(this.gboxUserChoice);
            this.Name = "frmSPSGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scissors Paper Stone";
            this.Load += new System.EventHandler(this.frmSPSGame_Load);
            this.gboxUserChoice.ResumeLayout(false);
            this.gboxUserChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.gboxCompChoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxComputer)).EndInit();
            this.gboxResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxUserChoice;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.RadioButton rbnStone;
        private System.Windows.Forms.RadioButton rbnPaper;
        private System.Windows.Forms.RadioButton rbnScissors;
        private System.Windows.Forms.GroupBox gboxCompChoice;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox pbxComputer;
        private System.Windows.Forms.GroupBox gboxResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnQuit;
        public System.Windows.Forms.Label lblComputerScore;
        public System.Windows.Forms.Label lblUserScore;
    }
}

