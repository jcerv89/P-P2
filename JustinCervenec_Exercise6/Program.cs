using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustinCervenec_Exercise6
{
    class Program
    {

    static void Main(string[] args)
        {
            //Holds deck of cards with the point values
            Dictionary<string, int> cards = new Dictionary<string, int>();
            cards.Add("Hearts", 2);
            cards.Add("Diamonds", 2);
            cards.Add("Spades", 2);
            cards.Add("Clubs", 2);
            cards.Add("Hearts", 3);
            cards.Add("Diamonds", 3);
            cards.Add("Spades", 3);
            cards.Add("Clubs", 3);
            cards.Add("Hearts", 4);
            cards.Add("Diamonds", 4);
            cards.Add("Spades", 4);
            cards.Add("Clubs", 4);
            cards.Add("Hearts", 5);
            cards.Add("Diamonds", 5);
            cards.Add("Spades", 5);
            cards.Add("Clubs", 5);
            cards.Add("Hearts", 6);
            cards.Add("Diamonds", 6);
            cards.Add("Spades", 6);
            cards.Add("Clubs", 6);
            cards.Add("Hearts", 7);
            cards.Add("Diamonds", 7);
            cards.Add("Spades", 7);
            cards.Add("Clubs", 7);
            cards.Add("Hearts", 8);
            cards.Add("Diamonds", 8);
            cards.Add("Spades", 8);
            cards.Add("Clubs", 8);
            cards.Add("Hearts", 9);
            cards.Add("Diamonds", 9);
            cards.Add("Spades", 9);
            cards.Add("Clubs", 9);
            cards.Add("Hearts", 10);
            cards.Add("Diamonds", 10);
            cards.Add("Spades", 10);
            cards.Add("Clubs", 10);
            cards.Add("Jack of Hearts", 12);
            cards.Add("Jack of Diamonds", 12);
            cards.Add("Jack of Spades", 12);
            cards.Add("Jack of Clubs", 12);
            cards.Add("Queen of Hearts", 12);
            cards.Add("Queen of Diamonds", 12);
            cards.Add("Queen of Spades", 12);
            cards.Add("Queen of Clubs", 12);
            cards.Add("King of Hearts", 12);
            cards.Add("King of Diamonds", 12);
            cards.Add("King of Spades", 12);
            cards.Add("King of Clubs", 12);
            cards.Add("Ace of Hearts", 15);
            cards.Add("Ace of Diamonds", 15);
            cards.Add("Ace of Spades", 15);
            cards.Add("Ace of Clubs", 15);

            Random shuffle = new Random();
            


            Console.WriteLine("Lets play cards!!\n");

            Console.WriteLine("Enter the names of the 4 players");
            //Loops to get and validate user name inputs
            Console.Write("Player 1 : \n");
            string name1 = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name1))
            {
                Console.WriteLine("Enter a name for this player.");
                name1 = Console.ReadLine();
            }
            Console.Write("Player 2 : \n");
            string name2 = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name2))
            {
                Console.WriteLine("Enter a name for this player.");
                name2 = Console.ReadLine();
            }
            Console.Write("Player 3 : \n");
            string name3 = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name3))
            {
                Console.WriteLine("Enter a name for this player.");
                name3 = Console.ReadLine();
            }
            Console.Write("Player 4 : \n");
            string name4 = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(name4))
            {
                Console.WriteLine("Enter a name for this player.");
                name4 = Console.ReadLine();
            }


        }
    }
}
