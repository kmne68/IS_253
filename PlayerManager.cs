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
    class PlayerManager
    {
        private string userID;
        public enum Throw {rock=1, paper, scissors};

        /******************************************************************************/
        public void makeAChoice()
        {
            string buffer;
            Console.Write("Enter a choice: ");
            buffer = Console.ReadLine();
            Throw rpsChoice;
            if (Enum.TryParse(buffer, true, out rpsChoice))
            {
                if (Enum.IsDefined(typeof(Throw), rpsChoice))
                    Console.WriteLine("Converted '{0}' to {1} with an integer value of {2}.", buffer, rpsChoice, (char)rpsChoice);
                else
                    Console.WriteLine("{0} is not an underlying value of the RPS.Choice enumeration.", buffer);
            }
            else
            {
                rpsChoice = (Throw)buffer[0];
                if (Enum.IsDefined(typeof(Throw), rpsChoice))
                    Console.WriteLine("Converted '{0}' to {1} with an integer value of {2}.", buffer, rpsChoice, (char)rpsChoice);
                else
                    Console.WriteLine("{0} is not an underlying value of the RPS.Choice enumeration.", buffer);
            }
        }
        /******************************************************************************/



        public PlayerManager(string userName)
        {
            userID = userName;
        }

   /*     public string UserID
        {
            get
            {
     //           Console.WriteLine("Hello. With whom am I playing today?");
               // string ID = Console.ReadLine();
                return UserID;
            }
        }
*/
 /*       public void greetUser()
        {
    //        string userName = UserID;
    //        Console.WriteLine("Good luck " + this.UserID);
        } */

        public string getUserInput()
        {
            String userChoice;
            Console.WriteLine("Please make your selection, Rock, Paper or Scissors");
            Console.WriteLine("Enter 'R' for Rock, 'P' for Paper or 'S' for Scissors");
            userChoice = Console.ReadLine().Substring(0, 1).ToUpper();

            if ((userChoice.Equals('R') || userChoice.Equals('S') || userChoice.Equals('P')))
            {
                Console.WriteLine((userChoice));
            }
            else
            {
                Console.WriteLine("Please enter a valid choice.");
            }
            return userChoice;
        }

        /**********************************************************/



    }
}
