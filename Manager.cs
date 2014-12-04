using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLoop
{
    public class Manager
    {
        private string playerFirst;
        private string playerLast;
        private int wins;
        private int losses;
        private int ties;

        public string firstName
        {
            get
            {
                return playerFirst;
            }
            set
            {
                playerFirst = value;
            }
        }

        public string lastName
        {
            get
            {
                return playerLast;
            }
            set
            {
                playerLast = value;
            }
        }

        public int playerWins
        {
            get
            {
                return wins;
            }
            set
            {
                wins = value;
            }
        }

        public int playerLosses
        {
            get
            {
                return losses;
            }
            set
            {
                losses = value;
            }
        }

        public int playerTies
        {
            get
            {
                return ties;
            }
            set
            {
                ties = value;
            }
        }

        public string getPlayerName()
        {
            string name;
            Console.WriteLine("Please enter your first name.");
            playerFirst = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            playerLast = Console.ReadLine();
            name = playerFirst + " " + playerLast;
            
            return name;
        }

        // Compose a string that consists of three lines.
        string lines = "First line.\r\nSecond line.\r\nThird line.";

        // Write the string to a file.
        System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\test.txt");
   //     file.WriteLine(lines);

   //     file.Close();
    }
}
