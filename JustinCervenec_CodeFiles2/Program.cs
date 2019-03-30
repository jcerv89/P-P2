using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustinCervenec_CodeFiles2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Career Saver!");//Welcome user

            //user will sign in

            //Menu for user

            bool programRunnning = true;

            while (programRunnning)
            {
                Console.WriteLine("What would you like to do?\n");
                //Menu for user
                Console.WriteLine("1. New Job Search\n2. My Jobs\n3. Exit\n");

                string userChoiceString = Console.ReadLine();

                switch (userChoiceString)
                {
                    case "1":
                        Data.JobListings();//Call class with SQL statements
                   

                        

                        break;

                    case "2":
                        Data.SavedJobs();
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;

                    default://Executes if initial selection is not listed on the menu

                        Console.WriteLine("Invalid Selection made. Try again.");

                        break;
                }


            }

            

            

            




            


        }
    }
}
