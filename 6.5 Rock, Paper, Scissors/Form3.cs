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
    public partial class FormInstruction : Form
    {
        public FormInstruction()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRPS f2 = new FormRPS();
            f2.ShowDialog();
        }
    }
}
