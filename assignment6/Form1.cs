using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private int GetComputerChoice()
        {
            Random rand = new Random();
            return rand.Next(1, 4);
        }


        private void DisplayChoices(int computerChoice)
        {
            switch (computerChoice)
            {
                case 1:
                    lblComputerChoice.Text = "Computer chose Rock";
                    break;
                case 2:
                    lblComputerChoice.Text = "Computer chose Paper";
                    break;
                case 3:
                    lblComputerChoice.Text = "Computer chose Scissors";
                    break;
            }
        }

        private void DetermineWinner(int userChoice, int computerChoice)
        {
            if (userChoice == computerChoice)
            {
                lblResult.Text = "It's a tie! Play again.";
            }
            else if ((userChoice == 1 && computerChoice == 3) ||
                     (userChoice == 2 && computerChoice == 1) ||
                     (userChoice == 3 && computerChoice == 2))
            {
                lblResult.Text = "You win!";
            }
            else
            {
                lblResult.Text = "You lose!";
            }
        }


        private void PlayGame(int userChoice)
        {
            int computerChoice = GetComputerChoice();
            DisplayChoices(computerChoice);
            DetermineWinner(userChoice, computerChoice);
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            PlayGame(1);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            PlayGame(2);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            PlayGame(3);
        }
    }
}
