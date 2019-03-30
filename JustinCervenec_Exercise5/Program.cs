using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustinCervenec_Exercise5
{
    class Program
    {

        static void Main(string[] args)
        {
            //array of options for the game
            string[] list = { "Rock", "Spock", "Paper", "Lizard", "Scissors" };

            //random object to generate random number

            System.Random random = new System.Random();

            //for counting wins

            int tie = 0, userWins = 0, computerCount = 0;

            
            
            //Shows the rules for the game
            Rules.Info();

            //loop 10 times for a round in the game
            for (int i = 0; i < 10; i++)
            {

                //Ask user what one the want to use against the computer

                Console.WriteLine("Which do you choose: (Paper, Rock, Scissors, Lizard, Spock) ? ");

                string user = Console.ReadLine().ToLower();

                //Creates a random selection for the system

                string computer = list[random.Next(0, list.Length)];

                //getting their respective number order for selection

                int computerNum = nameNumber(computer);

                int userNum = nameNumber(user);

                //Checks if the user entered an invalid word in the game
                //Goes to nameNumber method

                if (userNum == -1)
                {

                    Console.WriteLine("Invalid option! try again");

                    i--;

                    continue;

                }

                Console.WriteLine("Computer Selection : " + computer);

                // if statements to compare both number codes of choices

                if ((computerNum + 1) % 5 == userNum)
                {

                    Console.WriteLine("You win!!!!");

                    Console.WriteLine ("Player Wins: " +userWins++);

                }

                else if ((computerNum + 2) % 5 == userNum)
                {

                    Console.WriteLine("User wins!");

                    Console.WriteLine ("Player Wins: " +userWins++);

                }

                else if (computerNum == userNum)
                {

                    Console.WriteLine("User and computer tie!");

                    tie++;

                }

                else
                {

                    Console.WriteLine("Computer wins!");

                    Console.WriteLine("Player Losses: " + computerCount++);

                }

            }

            //Show game results after 10 iterations

            Console.WriteLine("\n\nResults of the game are as follows: ");

            Console.WriteLine("Player Win Count: " + userWins++);

            Console.WriteLine("Player/Computer Ties Count: " + tie++);

            Console.WriteLine("Player Loss Count: " + computerCount++);

            //After round is over, check if user wants to play again
            Console.WriteLine("Do you want to play again? Press Y for yes or press N for no to exit the program!");
            string userChoice = Console.ReadLine().ToLower();
            while (string.IsNullOrWhiteSpace(userChoice))
            {
                Console.WriteLine("Select Y for yes or N for no.");
                userChoice = Console.ReadLine().ToLower();
            }
            switch (userChoice)
            {
                case "y":
                    Main(args);//Restarts the game
                    Console.Clear();
                    break;

                case "n":
                    Environment.Exit(0);//Exits program

                    break;

                default:

                    Console.WriteLine("Enter a valid selection.");


                    return;

            }

        }

            //method to return corresponding order number for string code


            public static int nameNumber(string name)

            {

                name = name.ToLower();

                if (name == "rock")

                    return 0;

                else if (name == "spock")

                    return 1;

                else if (name == "paper")

                    return 2;

                else if (name == "lizard")

                    return 3;

                else if (name == "scissors")

                    return 4;

                else

                    return -1;

            }


        

    }
}
    

