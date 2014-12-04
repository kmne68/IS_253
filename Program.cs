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

namespace GameLoop
{
    class Program
    {

        public enum Throw {rock=1, paper, scissors};

        static void Main(string[] args)
        {
//            Console.WriteLine("enum value 2 = " + (Throw)2);

            bool badChoice = true;
            string keepPlaying = "y";
            string userChoice;

            Manager gameManager = new Manager();
            gameManager.getPlayerName();

            // Start the game loop
            while (keepPlaying == "Y" || keepPlaying == "y")
            {
                // Get user input
                 do {   Console.WriteLine("Please enter your selection, R for rock, P for paper, S for scissors.");
                 userChoice = Console.ReadLine();
                     // Check that user's input was valid (IMPROVE BY ACCEPTING ONE (FIRST) CHARACTER IN CASE PLAYER ENTERS ENTIRE WORD
                    if ((userChoice.Equals("R") || userChoice.Equals("S") || userChoice.Equals("P"))
                        || userChoice.Equals("r") || userChoice.Equals("s") || userChoice.Equals("p"))
                    {
                        badChoice = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid choice.");
                    }
                 } 
                 // If the player's choice was bad, continue prompting for input
                while (badChoice == true);

                // Instantiate an RPS object with the users selection
                RockPaperScissors RPS = new RockPaperScissors(userChoice);

                // Repeat players choice to them
                if(RPS.playerChoiceToInt(userChoice) == 0)
                    Console.WriteLine("You have chosen Rock."); // Tried using Enum Throw(RPS.playerChoiceToInt(userChoice))--does not exist in current context?
                else if (RPS.playerChoiceToInt(userChoice) == 3)
                    Console.WriteLine("You have chosen Paper.");
                else
                    Console.WriteLine("You have chosen Scissors.");

                // Tell the player the computer's choice
                Console.WriteLine("The computer chooses " + RPS.computerChoiceToString(RPS.computerThrow()));

                // Determine the winner and store the result
                string result = RPS.determineWinner(RPS.computerThrow(), RPS.playerChoiceToInt(userChoice));

                // Display results
                if(result == "tie")
                    Console.WriteLine("Tie game.");
                else
                Console.WriteLine("The winner is the " + result + ".");

                Console.WriteLine(gameManager.firstName + " " + gameManager.lastName);

                Console.WriteLine("Do you wish to play again? Enter 'Y' for yes, press any other key for no.");
                keepPlaying = Console.ReadLine();
            }
        }     
    }   
}
