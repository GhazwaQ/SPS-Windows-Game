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
    public partial class frmWinning : Form
    {
        public frmWinning()
        {
            InitializeComponent();
        }

        private void frmWinning_Load(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
