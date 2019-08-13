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
    public partial class frmDraw : Form
    {
        public frmDraw()
        {
            InitializeComponent();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //we are going to show the form of the SPS game again
            this.Close();
        }

        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblFinalUser_Click(object sender, EventArgs e)
        {
           
        }

        private void frmDraw_Load(object sender, EventArgs e)
        {

        }
    }
}
