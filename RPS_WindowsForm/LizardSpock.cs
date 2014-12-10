﻿/******************************************************************************
 * Keith Emery
 * IS 253
 * 2014/12/09
 * RPS is a simple rock, paper, scissors game. The program asks the user for
 * his/her choice, gets a random choice for the computer then determines
 * whether the player or the computer has won using the familiar rules of the
 * game. This is the Windows Form version. There is also a console version.
 * 
 * ***************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Collections;

namespace RPS_WindowsForm
{
    public partial class LizardSpock : BaseForm
    {
        public LizardSpock()
        {
            InitializeComponent();
        }

        /*******************/
        private string userChoice;

        Assembly assembly;
        Stream imageStream;
        string[] imageNames = new string[] {    "paper.bmp", "paper_drawn.bmp", "paper_object.bmp",
                                                "rock.bmp", "rock_drawn.bmp", "rock_object.bmp",
                                                "scissors.bmp", "scissors_drawn.bmp", "scissors_object" };
        private void LizardSpock_Load(object sender, EventArgs e)
        {
            try
            {
                assembly = Assembly.GetExecutingAssembly();
 //               imageStream = assembly.GetManifestResourceStream("RPS_WindowsForm.Images.paper.bmp");
            }
            catch
            {
                MessageBox.Show("Error accessing resources.");
            }
        }
       // List<ImageInfo> imageList = new List<ImageInfo>();



        private void btn_rock_Click(object sender, EventArgs e)
        {
            userChoice = "r";
            RockPaperScissors RPS = new RockPaperScissors(userChoice);
            int computerThrow = RPS.expandedComputerThrow();
            int playerThrow = RPS.playerChoiceToInt(userChoice);
            txt_computerChoice.Text = RPS.computerChoiceToString(computerThrow);
            txt_winner.Text = RPS.determineWinner(computerThrow, playerThrow);
            btn_rock.BackColor = Color.AliceBlue;

            try
            {
                imageStream = assembly.GetManifestResourceStream("RPS_WindowsForm.Images.rock.bmp");
                //Bitmap image = new Bitmap(type.Assembly.GetManifestResourceStream(imageStream));
                pbx_rock.Show();
                pbx_rock.Image = new Bitmap(imageStream);
            }
            catch
            {
                MessageBox.Show("Error creating image.");
            }
        }

        private void btn_paper_Click(object sender, EventArgs e)
        {
            userChoice = "p";
            RockPaperScissors RPS = new RockPaperScissors(userChoice);
            int computerThrow = RPS.expandedComputerThrow();
            int playerThrow = RPS.playerChoiceToInt(userChoice);
            txt_computerChoice.Text = RPS.computerChoiceToString(computerThrow);
            txt_winner.Text = RPS.determineWinner(computerThrow, playerThrow);
            btn_paper.BackColor = Color.DarkRed;
            btn_paper.ForeColor = Color.AntiqueWhite;
            MessageBox.Show("paper click");

            try
            {
                imageStream = assembly.GetManifestResourceStream("RPS_WindowsForm.Images.paper.bmp");
                //Bitmap image = new Bitmap(type.Assembly.GetManifestResourceStream(imageStream));
                pbx_paper.Show();
                pbx_paper.Image = new Bitmap(imageStream);
            }
            catch
            {
                MessageBox.Show("Error creating image.");
            }
        }

        private void btn_scissors_Click(object sender, EventArgs e)
        {
            userChoice = "s";
            RockPaperScissors RPS = new RockPaperScissors(userChoice);
            int computerThrow = RPS.expandedComputerThrow();
            int playerThrow = RPS.playerChoiceToInt(userChoice);
            txt_computerChoice.Text = RPS.computerChoiceToString(computerThrow);
            txt_winner.Text = RPS.determineWinner(computerThrow, playerThrow);
            btn_scissors.BackColor = Color.DarkSeaGreen;

            try
            {
                imageStream = assembly.GetManifestResourceStream("RPS_WindowsForm.Images.scissors.bmp");
                //Bitmap image = new Bitmap(type.Assembly.GetManifestResourceStream(imageStream));
                pbx_scissors.Show();
                pbx_scissors.Image = new Bitmap(imageStream);
            }
            catch
            {
                MessageBox.Show("Error creating image.");
            }
        }

        private void btn_lizard_Click(object sender, EventArgs e)
        {
            userChoice = "l";
            RockPaperScissors LS = new RockPaperScissors(userChoice);
            int computerThrow = LS.expandedComputerThrow();
            int playerThrow = LS.playerChoiceToInt(userChoice);
            txt_computerChoice.Text = LS.computerChoiceToString(computerThrow);
            txt_winner.Text = LS.determineWinner(computerThrow, playerThrow);
            btn_lizard.BackColor = Color.GreenYellow;
        }

        private void btn_spock_Click(object sender, EventArgs e)
        {
            userChoice = "k";
            RockPaperScissors LS = new RockPaperScissors(userChoice);
            int computerThrow = LS.expandedComputerThrow();
            int playerThrow = LS.playerChoiceToInt(userChoice);
            txt_computerChoice.Text = LS.computerChoiceToString(computerThrow);
            txt_winner.Text = LS.determineWinner(computerThrow, playerThrow);
            btn_spock.BackColor = Color.DodgerBlue;
        }

        private void btn_playAgain_Click(object sender, EventArgs e)
        {
            btn_rock.BackColor = SystemColors.Control;
            btn_paper.BackColor = SystemColors.Control;
            btn_paper.ForeColor = Color.Black;
            btn_scissors.BackColor = SystemColors.Control;
            btn_lizard.BackColor = SystemColors.Control;
            btn_spock.BackColor = SystemColors.Control;
            txt_computerChoice.Clear();
            txt_winner.Clear();
            pbx_paper.Hide();
            pbx_rock.Hide();
            pbx_scissors.Hide();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            ChooseGame game = new ChooseGame();
            game.Show();
        }




    }
        /********************/
}
