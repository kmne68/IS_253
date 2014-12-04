/******************************************************************************
 * Keith Emery
 * IS 253
 * 2014/09/21
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


namespace RPS_WindowsForm
//namespace GameLoop

{
    public partial class RPS_Form : BaseForm
    {
        private string userChoice;

        public RPS_Form()
        {
            InitializeComponent();
        }

        private BindingSource usersBindingSource = new BindingSource();


        private void btn_rock_Click(object sender, EventArgs e)
        {
            userChoice = "r";
            RockPaperScissors RPS = new RockPaperScissors(userChoice);
            int computerThrow = RPS.computerThrow();
            int playerThrow = RPS.playerChoiceToInt(userChoice);
            txt_computerChoice.Text = RPS.computerChoiceToString(computerThrow);
            txt_winner.Text = RPS.determineWinner(computerThrow, playerThrow);
            btn_rock.BackColor = Color.AliceBlue;
        }

        private void btn_paper_Click(object sender, EventArgs e)
        {
            userChoice = "p";
            RockPaperScissors RPS = new RockPaperScissors(userChoice);
            int computerThrow = RPS.computerThrow();
            int playerThrow = RPS.playerChoiceToInt(userChoice);
            txt_computerChoice.Text = RPS.computerChoiceToString(computerThrow);
            txt_winner.Text = RPS.determineWinner(computerThrow, playerThrow);
            btn_paper.BackColor = Color.DarkRed;
            btn_paper.ForeColor = Color.AntiqueWhite;
        }

        private void btn_scissors_Click(object sender, EventArgs e)
        {
            userChoice = "s";
            RockPaperScissors RPS = new RockPaperScissors(userChoice);
            int computerThrow = RPS.computerThrow();
            int playerThrow = RPS.playerChoiceToInt(userChoice);
            txt_computerChoice.Text = RPS.computerChoiceToString(computerThrow);
            txt_winner.Text = RPS.determineWinner(computerThrow, playerThrow);
            btn_scissors.BackColor = Color.DarkSeaGreen;
        }

        private void btn_playAgain_Click(object sender, EventArgs e)
        {
            btn_rock.BackColor = SystemColors.Control;
            btn_paper.BackColor = SystemColors.Control;
            btn_paper.ForeColor = Color.Black;
            btn_scissors.BackColor = SystemColors.Control;
            txt_computerChoice.Clear();
            txt_winner.Clear();

        }
        /*
        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usersDataSet);

        } */
    }
}
