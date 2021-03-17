using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._5_Rock__Paper__Scissors
{
    public partial class FormRPS : Form
    {
        public FormRPS()
        {
            InitializeComponent();
        }

        private void radRock_CheckedChanged(object sender, EventArgs e)
        {

            if (radRock.Checked == true)
            {
                imgPlayer.Image = Properties.Resources.Rock;
            }

        }

        private void radPaper_CheckedChanged(object sender, EventArgs e)
        {

            if (radPaper.Checked == true)
            {
                imgPlayer.Image = Properties.Resources.Paper;
            }
           
        }

        private void radScissors_CheckedChanged(object sender, EventArgs e)
        {
            imgPlayer.Image = Properties.Resources.Scissors;
        }
    }
}
