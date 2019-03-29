using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustinCervenec_Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //contains facts about 7 given colrs
            Dictionary<string, string > colors = new Dictionary<string, string>();
         
            colors.Add("Red", "Red is often the color of anger.\nRed mean beautiful in Russian.\nThere are 23 shades of red crayons.");
            colors.Add("Orange", "Orange often represents stregth.\nIn France, the middle traffic light is orange rather than yellow.\nPrisons use orange uniforms for prisoners.");
            colors.Add("Yellow", "Yellow is used as a unisex color.\nIt is the color of happiness and sunshine.\nIt is the most visible color of the light spectrum.");
            colors.Add("Green", "Greem means go for traffic signals.\nGreem is the national color of Ireland.\nGreen is the second most popular color.");
            colors.Add("Blue", "Blue is the most popular favorite color.\nBlue is a primary color.\nIt represents the sky and the oceans.");
            colors.Add("Indigo", "Indigo is one of the seven colors of a rainbow.\nThe shade sits between blue and violet.\nSome grapes are Indigo in color.");
            colors.Add("Violet", "Violet is towards the end of the visible spectrum.\nIn Japan, violet is associated with wealth.\nThe name comes from the violet flower.");
            
            

            
            Console.WriteLine("Select your favorite color, or any color to want to know about!");
            //Menu for user to choose from
            Console.WriteLine("1. Red\n2. Orange\n3. Yellow\n4. Green\n5. Blue\n6. Indidgo\n7. Violet/n0. Exit");

            bool programRunning = true;
            string userChoice = Console.ReadLine().ToLower();//Get user selection

            while (programRunning)
            {
                switch (userChoice)
                {
                    case "1":
                    case "red":
                       
                        Console.WriteLine(colors.Values.ElementAt(0));//This calls specific color and facts at specified index.
                        Main(args);
                        return;
                        
                    case "2":
                    case "orange":

                        Console.WriteLine(colors.Values.ElementAt(1));
                        Main(args);
                        return;

                    case "3":
                    case "yellow":

                        Console.WriteLine(colors.Values.ElementAt(2));
                        Main(args);
                        return;

                    case "4":
                    case "green":

                        Console.WriteLine(colors.Values.ElementAt(3));
                        Main(args);
                        return;

                    case "5":
                    case "blue":

                        Console.WriteLine(colors.Values.ElementAt(4));
                        Main(args);
                        return;

                    case "6":
                    case "indigo":

                        Console.WriteLine(colors.Values.ElementAt(5));
                        Main(args);
                        return;

                    case "7":
                    case "violet":

                        Console.WriteLine(colors.Values.ElementAt(6));
                        Main(args);
                        return;

                    case "0":
                    case "exit":
                        Environment.Exit(0);//Exit program
                        break;

                    default:
                        Console.WriteLine("Invalid option");//Informs user input is bad
                        Main(args);
                        break;
                        


                }
            }
        }
    }
}
