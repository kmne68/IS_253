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
using System.Linq;
using System.Text;

namespace RPS_WindowsForm
{
    class RockPaperScissors
    {
        public enum Throw { rock = 1, paper, scissors };
        private int playerChoice;
        private int computerChoice;

        // Winner array to obtain the string associated with the numeric determination of the winner
        private string[] winner = new string[9] {"tie", "computer", "player", "player", "tie", "computer", "computer", "player", "tie"};

        // Parameterized constructor
        public RockPaperScissors(string playerThrow)
        {
            PlayerChoice = playerChoiceToInt(playerThrow);
            computerChoice = computerThrow();
        }

        public int PlayerChoice
        {
            set 
            {
                playerChoice = value;
            }
            get
            {
                return playerChoice;
            }
        }

        // Convert the player's choice to an integer to simplify processing
        public int playerChoiceToInt(string choice)
        {
            if (choice.Equals("R") || (choice.Equals("r")))
                return 0;
            else if (choice.Equals("P") || (choice.Equals("p")))
                return 3;
            else
                return 6;
        }

        // Convert the computer's choice to a string for displaying to the player
        public string computerChoiceToString(int computerThrow)
        {
            if (computerThrow == 0)
                return "Rock";
            else if (computerThrow == 1)
                return "Paper";
            else
                return "Scissors";
        }

        // Generate a random number between 0 and two (inclusive) to correspond to R, P or S
        public int computerThrow()
        {
            Random rnd = new Random();
            int randomThrow = rnd.Next(0, 3);
            return randomThrow;
        }

        // Determine the winner of the game by comparing results
        // Each player-choice combination has a different integer value. That value is then used
        // as an index to access the appropriate value of the winner array.
        public string determineWinner(int computer, int player)
        {
            int result = player + computer;
            string matchWinner = winner[result];
            //string winner;
   /*         switch (result)
            {
                case 0:
                case 5:
                case 10:
                    winner = "tie";
                    break;
                case 1:
                case 2:
                case 6:
                    winner = "computer";
                    break;
                default:
                    winner = "player";
                    break;
            } */
            return matchWinner;   
        }
    }
}
