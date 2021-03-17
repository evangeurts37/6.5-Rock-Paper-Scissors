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


        Random generator = new Random();


        int OpponentPick;
        int Wins;
        int Loses;
        int Ties;



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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            OpponentPick = generator.Next(1, 4);

            if (OpponentPick == 1)
            {
                imgOpponent.Image = Properties.Resources.Rock;
            }

            else if (OpponentPick == 2)
            {
                imgOpponent.Image = Properties.Resources.Paper;
            }

            else if (OpponentPick == 3)
            {
                imgOpponent.Image = Properties.Resources.Scissors;
            }


            if (OpponentPick == 1 & radRock.Checked == true)
            {
                lblResult.Text = "Tie";
                Ties += 1;
                lblTies.Text = Ties + "" ;
            }
            else if (OpponentPick == 1 & radPaper.Checked == true)
            {
                lblResult.Text = "You Win";
                Wins += 1;
                lblWins.Text = Wins + "";
            }
            else if (OpponentPick == 1 & radScissors.Checked == true)
            {
                lblResult.Text = "You Lose";
                Loses += 1;
                lblLoses.Text = Loses + "";
            }
            else if (OpponentPick == 2 & radRock.Checked == true)
            {
                lblResult.Text = "You Lose";
                Loses += 1;
                lblLoses.Text = Loses + "";
            }
            else if (OpponentPick == 2 & radPaper.Checked == true)
            {
                lblResult.Text = "Tie";
                Ties += 1;
                lblTies.Text = Ties + "";
            }
            
            else if (OpponentPick == 2 & radScissors.Checked == true)
            {
                lblResult.Text = "You Win";
                Wins += 1;
                lblWins.Text = Wins + "";
            }
            
            else if (OpponentPick == 3 & radRock.Checked == true)
            {
                lblResult.Text = "You Win";
                Wins += 1;
                lblWins.Text = Wins + "";
            }
            else if (OpponentPick == 3 & radPaper.Checked == true)
            {
                lblResult.Text = "You Lose";
                Loses += 1;

            }
            else if (OpponentPick == 3 & radScissors.Checked == true)
            {
                lblResult.Text = "Tie";
                Ties += 1;
            }
        }
        }
    } 
