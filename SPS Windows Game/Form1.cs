using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPS_Windows_Game
{
    public partial class frmSPSGame : Form
    {
        int userChoice, compChoice;
        int userScore = 0;
        int compScore = 0;
    
        public frmSPSGame()
        {
            InitializeComponent();
        }

        private void rbnScissors_CheckedChanged(object sender, EventArgs e)
        {
            pbxUser.Image = Image.FromFile("Scissors.jpg");
            userChoice = 1;
        }

        private void rbnPaper_CheckedChanged(object sender, EventArgs e)
        {
            pbxUser.Image = Image.FromFile("Paper.jpg");
            userChoice = 2;
        }

        private void rbnStone_CheckedChanged(object sender, EventArgs e)
        {
            pbxUser.Image = Image.FromFile("Stone.jpg");
            userChoice = 3;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Random r = new Random(); //create a new random object r
            compChoice = r.Next(3) + 1; //use r to pick a number from 1 to 3
            if (compChoice == 1)
            {
                pbxComputer.Image = Image.FromFile("Scissors.jpg");
            }

            else if (compChoice == 2)
            {
                pbxComputer.Image = Image.FromFile("Paper.jpg");

            }
            else if (compChoice == 3)
            {
                pbxComputer.Image = Image.FromFile("Stone.jpg");
            }

            checkResult();
                if (compScore == 20 || userScore == 20 )
                {
                    finish();
                }
        }
        private void checkResult()
        {
            lblResult.BackColor = Color.White;
            lblUserScore.BackColor = Color.White;
            lblComputerScore.BackColor = Color.White;
           
                if (compChoice == userChoice)
                {
                    lblResult.Text = "It's a DRAW!";
                    compScore += 1;
                    userScore += 1;
                    lblResult.ForeColor = Color.Black;
                }
                else if (compChoice == 1 && userChoice == 2) //scissors / paper
                {
                    lblResult.Text = "Computer WINS!";
                    compScore += 2;
                    lblResult.ForeColor = Color.Black;
                }
                else if (compChoice == 1 && userChoice == 3) //scissors / stone
                {
                    lblResult.Text = "You WIN!";
                    userScore += 2;
                    lblResult.BackColor = Color.Red;
                    lblResult.ForeColor = Color.Yellow;
                }
                else if (compChoice == 2 && userChoice == 1) //paper / scissors
                {
                    lblResult.Text = "You WIN!";
                    userScore += 2;
                    lblResult.BackColor = Color.Red;
                    lblResult.ForeColor = Color.Yellow;
                }
                else if (compChoice == 2 && userChoice == 3) //paper / stone
                {
                    lblResult.Text = "Computer WINS!";
                    compScore += 2;
                    lblResult.ForeColor = Color.Black;
                }
                else if (compChoice == 3 && userChoice == 1) //stone /scissors
                {
                    lblResult.Text = "Computer WINs!";
                    compScore += 2;
                    lblResult.ForeColor = Color.Black;
                }
                else if (compChoice == 3 && userChoice == 2) //stone / paper
                {
                    lblResult.Text = "You WIN!";
                    userScore += 2;
                    lblResult.BackColor = Color.Red;
                    lblResult.ForeColor = Color.Yellow;
                }
                lblComputerScore.Text = "Computer Score \n" + compScore.ToString();
                lblUserScore.Text = "User Score \n" + userScore.ToString();
        }
        private void finish()
        {
            if(compScore == userScore )
            {
                //load the Draw form
                frmDraw draw = new frmDraw();
                draw.ShowDialog();
            }
            else if(compScore > userScore )
            {
                //load the Losin form
                frmLosing lose = new frmLosing();
                lose.ShowDialog();
            }
            else if(compScore < userScore )
            {
                //load the Winning form
                frmWinning Win = new frmWinning();
                Win.ShowDialog();
            }           
        }
        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void frmSPSGame_Load(object sender, EventArgs e)
        {
            frmSplash SScreen = new frmSplash();
            SScreen.ShowDialog();
            pbxUser.Image = Image.FromFile("sps1.jpg");
            pbxComputer.Image = Image.FromFile("sps3.jpg");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
