namespace SPS_Windows_Game
{
    partial class frmDraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDraw));
            this.lblFinalUser = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnQuitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFinalUser
            // 
            this.lblFinalUser.AutoSize = true;
            this.lblFinalUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFinalUser.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalUser.ForeColor = System.Drawing.Color.IndianRed;
            this.lblFinalUser.Location = new System.Drawing.Point(85, 22);
            this.lblFinalUser.Name = "lblFinalUser";
            this.lblFinalUser.Size = new System.Drawing.Size(143, 27);
            this.lblFinalUser.TabIndex = 0;
            this.lblFinalUser.Text = "It is a Draw..";
            this.lblFinalUser.Click += new System.EventHandler(this.lblFinalUser_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlayAgain.Location = new System.Drawing.Point(35, 267);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(94, 28);
            this.btnPlayAgain.TabIndex = 1;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnQuitGame
            // 
            this.btnQuitGame.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuitGame.Location = new System.Drawing.Point(177, 267);
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.Size = new System.Drawing.Size(94, 28);
            this.btnQuitGame.TabIndex = 2;
            this.btnQuitGame.Text = "Quit ";
            this.btnQuitGame.UseVisualStyleBackColor = true;
            this.btnQuitGame.Click += new System.EventHandler(this.btnQuitGame_Click);
            // 
            // frmDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(307, 307);
            this.Controls.Add(this.btnQuitGame);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblFinalUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDraw";
            this.Text = "Game Over";
            this.Load += new System.EventHandler(this.frmDraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnQuitGame;
        public System.Windows.Forms.Label lblFinalUser;
    }
}