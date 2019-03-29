using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustinCervenec_Excerise1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> food = new List<string>();//List of items
            food.Add("Potato");
            food.Add("Pear");
            food.Add("Apple");
            food.Add("Cucumber");
            food.Add("Banana");
            food.Add("Tomato");
            food.Add("Carrot");
            food.Add("Celery");
            food.Add("Mushroom");
            food.Add("Squash");
            food.Add("Peas");
            food.Add("Lettuce");
            food.Add("Cabbage");
            food.Add("Strawberry");
            food.Add("Blueberry");
            food.Add("Peach");
            food.Add("Kimi");
            food.Add("Lime");
            food.Add("Lemon");
            food.Add("Grape");

            //count total items in the list
            int count = food.Count();
            //Display menu options to user
            Console.WriteLine("Enter 1 for sort in asc order");
            Console.WriteLine("Enter 2 for sort in desc order");
            Console.WriteLine("Enter 3 for delete all elements of list\r\n");

            Console.Write("Enter choice: ");

            string choiceString = Console.ReadLine();
            int choice;

            //Verify user input
            while(!int.TryParse(choiceString, out choice))
            {
                Console.WriteLine("Enter a valid option of 1, 2 or 3 from the menu.");
                choiceString = Console.ReadLine();
            }

            if (choice == 1)//Displays items in alphebetical order
            {
                food.Sort();
                foreach (var el in food)
                    Console.WriteLine(el);
                Main(args);
            }
            else if (choice == 2)//Displays items in reverse alphebetical order
            {

                food.Sort();
                food.Reverse();
                foreach (var el in food)
                    Console.WriteLine(el);
                Main(args);
            }
            //Removes all items in random order when selected
            else if (choice == 3)
            {
                Random rnd = new Random();
                int item = rnd.Next(count);
                int num = 0;
                int x = count;

                while (num < count)//Goes through the list and removes each one, until none remain
                {

                    food.RemoveAt(item);
                    Console.WriteLine("Element removed from " + item.ToString() + " index");
                    num = num + 1;
                    x = x - 1;
                    item = rnd.Next(x);
                   

                }
                
            }
            else
                Console.WriteLine("Wrong choice");
            Console.ReadLine();

        }
    }
}
    

