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
        public enum Throw { rock, paper, scissors, lizard, Spock };
        public enum Participants { Player, Computer }; // will use for validation
        private int playerChoice;

        // Winner array to obtain the string associated with the numeric determination of the winner NOTE no longer necessary, replaced with
        // two-dimensional array expandedWinner which works for classic RPS and RPSLS
        private string[] winner = new string[9] {"tie", "computer", "player", "player", "tie", "computer", "computer", "player", "tie"};
        private string[,] expandedWinner = new string[,] {  {"tie", "paper", "rock", "rock", "Spock"},
                                                            {"paper", "tie", "scissors", "lizard", "paper" },
                                                            {"rock", "scissors", "tie", "scissors", "Spock" },
                                                            {"rock", "lizard", "scissors", "tie", "lizard" },
                                                            {"Spock", "paper", "Spock", "lizard", "tie" } };


        // Parameterized constructor NOTE: Cleaned this up 12/12 as it the player throw was being passed twice
        // once at instantiation and again as a parameter to playerChoiceToInt.
        public RockPaperScissors() //string playerThrow
        {
 //           PlayerChoice = playerChoiceToInt(playerThrow);
        }

        // Set PlayerChoice property
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

        /// <summary>
        /// Converts the player's choice to an integer to simplify processing (for console version)
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>

        public int playerChoiceToInt(string choice)
        {
            int playerPick;
            if (choice.Equals("R") || (choice.Equals("r")))
                playerPick = 0;
            else if (choice.Equals("P") || (choice.Equals("p")))
                playerPick = 1;
            else if (choice.Equals("S") || (choice.Equals("s")))
                playerPick = 2;
            else if (choice.Equals("L") || (choice.Equals("l")))
                playerPick = 3;
            else
                playerPick = 4;
            return playerPick;
        }

        /// <summary>
        /// Convert the computer's choice to a string for display
        /// </summary>
        /// <param name="computerThrow"></param>
        /// <returns></returns>
        public string computerChoiceToString(int computerThrow)
        {
            string computerPick;
            if (computerThrow == 0)
                computerPick = "Rock";
            else if (computerThrow == 1)
                computerPick = "Paper";
            else if (computerThrow == 2)
                computerPick = "Scissors";
            else if (computerThrow == 3)
                computerPick = "Lizard";
            else
                computerPick = "Spock";
            return computerPick;
        }

        /// <summary>
        /// Generate a random number between 0 and two (inclusive) to correspond to R, P. S, L or Spock
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        public int computerThrow(int choice)
        {
            Random rnd = new Random();
            int randomThrow = rnd.Next(0, choice);
            return randomThrow;
        }

        // Generate a random number between 0 and 4 (inclusive) to correspond to R, P, S, L or Spock
        // no longer necessary because of parameterized computerThrow function
 /*       public int expandedComputerThrow()
        {
            Random rnd = new Random();
            int randomThrow = rnd.Next(0, 5);
            return randomThrow;
        } */

        /// <summary>
        ///  etermine the winner of the game by comparing results Each player-choice combination has a different 
        ///  integer value. That value is then used as an index to access the appropriate value of the winner array.
        ///  NOTE: 12/12 An early version used a switch statement to determine the winner, that was replaced with 
        ///  an array and finally a two-dimensional array.
        ///  The winner was initially determined mathematically.
        ///  Early version also returned winning throw rather than winning player.
        /// </summary>
        /// <param name="computer"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        public string determineWinner(int computer, int player)
        {
            //int result = player + computer;
            string matchWinner = expandedWinner[computer, player];
            //string matchWinner = winner[result];
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
            if (matchWinner.Equals(computer))
            {
                matchWinner = "Computer wins!";
            }
            else if (matchWinner.Equals(player))
                matchWinner = "You win!";
            else
                matchWinner = "Tie";
            return matchWinner;   
        }
    }
}
