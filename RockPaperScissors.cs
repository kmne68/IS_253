using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLoop
{
    class RockPaperScissors
    {

        private int playerChoice;
        private int computerChoice;

        public RockPaperScissors(string playerThrow)
        {
            playerChoice = playerChoiceToInt(playerThrow);
            computerChoice = computerThrow();
        }

        public int playerChoiceToInt(string choice)
        {
            if (playerChoice.Equals("R"))
                return 0;
            else if (playerChoice.Equals("P"))
                return 3;
            else
                return 6;
        }

        public int computerThrow()
        {
            Random rnd = new Random();
            int randomThrow = rnd.Next(1, 4);
            return randomThrow;
        }

        public string determineWinner()
        {
            int result = playerChoice + computerChoice;
            string winner;
            switch (result)
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
            }
            return winner;   
        }
    }
}
