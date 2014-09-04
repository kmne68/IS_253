using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            String userChoice;
            Console.WriteLine("Please make your selection, Rock, Paper or Scissors");
            Console.WriteLine("Enter 'R' for Rock, 'P' for Paper or 'S' for Scissors");
            userChoice = Console.ReadLine().Substring(0,1).ToUpper();

            if (!userChoice.Equals('R') || !userChoice.Equals('S') || !userChoice.Equals('P'))
            {
                Console.WriteLine("Please enter a valid choice.");
            }
            else
            {
                Console.WriteLine((userChoice));
            }
                
            RockPaperScissors RPS = new RockPaperScissors(userChoice);

            Console.WriteLine(RPS.determineWinner());
            Console.ReadLine();
        }
        
    }
    
}
