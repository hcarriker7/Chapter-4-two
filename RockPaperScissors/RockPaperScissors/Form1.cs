using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int rock = 1;
        int paper = 2;
        int scissors = 3;
         

        private void btnRock_Click(object sender, EventArgs e)
        {
            Random ranRPS = new Random();
            int randomRPS;
            randomRPS = ranRPS.Next(1, 4);

            if (randomRPS == rock)
            {
                lblResult.Text = ("Its a tie");
            }
            if (randomRPS == paper)
            {
                lblResult.Text = ("Computer wins because paper beats rock");
            }
            if (randomRPS == scissors)
            {
                lblResult.Text = ("You win because rock beats scissors");
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            Random ranRPS = new Random();
            int randomRPS;
            randomRPS = ranRPS.Next(1, 4);

            if (randomRPS == rock)
            {
                lblResult.Text = ("You win because paper beats rock");
            }
            if (randomRPS == paper)
            {
                lblResult.Text = ("Its a tie");
            }
            if (randomRPS == scissors)
            {
                lblResult.Text = ("Computer wins because scissors beats paper");
            }
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            Random ranRPS = new Random();
            int randomRPS;
            randomRPS = ranRPS.Next(1, 4);

            if (randomRPS == rock)
            {
               lblResult.Text= ("Computer wins because rock beats scissors");
            }
            if (randomRPS == paper)
            {
                lblResult.Text = ("You win because scissors beats paper");
            }
            if (randomRPS == scissors)
            {
                lblResult.Text = ("Its a tie");
            }
        }
    }


}
