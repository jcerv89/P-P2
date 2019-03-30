using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustinCervenec_CodeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello! What would you like to do today?");

            //Menu for user to select from
            Console.WriteLine("1. Select Activity\n2. View Tracked Data\n3. Run Calculations\n4 .Exit Program");

            string userChoiceString = Console.ReadLine();
            int userChoice;
            while (!int.TryParse(userChoiceString, out userChoice) && userChoice<1 || userChoice>4)//verify user input is valid
            {
                Console.WriteLine("Please select a valid numeric option from the menu.");
                userChoiceString = Console.ReadLine();
            }

           

            bool programRunning = true;
            while (programRunning)
            {
                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Select a catagory.");
                        Category();
                        Console.WriteLine("Pick an activity description.");
                        //Pull from database
                        Console.WriteLine("What day did you perfrom the activities?");
                        //Pull from database
                        Console.WriteLine("How long did you perfrom the activities? Enter a day number 1 through 26.");
                        string userDayString = Console.ReadLine();
                        int userDay;
                        while (!int.TryParse(userDayString, out userDay) && userDay < 1 || userDay>26)
                        {
                            Console.WriteLine("Please enter a day number between 1 and 26. ");
                            userDayString = Console.ReadLine();
                        }
                        Console.WriteLine("How long did you perform the activity?");
                        //Will save input to database
                        Main(args);
                        return;

                    case 2:
                        Console.WriteLine("How would you like to view the data?\n");
                        Console.WriteLine("1. Select by Date\n2. Select by Category\n3. Select by Description");
                        string userDataString = Console.ReadLine();
                        int userData;
                        //verify user input
                        while(!int.TryParse(userDataString, out userData) && userData < 1 || userData > 3)
                        {
                            Console.WriteLine("Select a valid option to view the data.");
                            userDataString = Console.ReadLine();
                        }
                        if (userData ==1)
                        {
                            Console.WriteLine("Which date would you like information about?");
                            //Pull dates from data base
                        }
                        if (userData==2)
                        {
                            Console.WriteLine("What category would you like to see?");
                            //Pull from database
                        }
                        if (userData ==3)
                        {
                            Console.WriteLine("Which description would you like to see?");
                            //pull from database
                        }
                        return;

                    case 3:
                        Console.WriteLine("What calculations do you want to see?");
                        //Menu for calcualtions
                        Console.WriteLine("1. Time spent on school work.");
                        Console.WriteLine("2. Time spent driving.");
                        Console.WriteLine("3. Number of times spent with family");
                        Console.WriteLine("4. Time spent with friends.");
                        Console.WriteLine("5. Time spent sleeping this month.");
                        Console.WriteLine("6. Time spent at work.");
                        Console.WriteLine("7. Time spent eating.");
                        Console.WriteLine("8. Time spent watching TV.");
                        Console.WriteLine("9. Time spent playing XBOX.");
                        Console.WriteLine("10. Total time spent resting and relaxing.");

                        string userCalcString = Console.ReadLine();
                        int userCalc;
                        //Check user input
                        while (!int.TryParse(userCalcString, out userCalc)&& userCalc<1 || userCalc > 10)
                        {
                            Console.WriteLine("Select valid choice from the calclations menu");
                            userCalcString = Console.ReadLine();
                        }
                        if(userCalc == 1)
                        {
                            
                        }
                        else if (userCalc == 2)
                        {

                        }
                        else if (userCalc == 3)
                        {
                            DatabaseConnect.Connect();
                            Main(args);
                        }
                        else if (userCalc == 4)
                        {

                        }
                        else if (userCalc == 5)
                        {
                            int sleep = 8 * 26;
                            Console.WriteLine("You spent a total of "+ sleep +" hours sleeping this month");
                        }
                        else if (userCalc == 6)
                        {
                            int work = 6 * 18;
                            Console.WriteLine("You Spent "+ work+" hours at work.");
                        }
                        else if (userCalc == 7)
                        {

                        }
                        else if (userCalc == 8)
                        {

                        }
                        else if (userCalc == 9)
                        {

                        }
                        else if (userCalc == 10)
                        {

                        }
                        return;

                    case 4:
                        Environment.Exit(0);
                        break;

                  

                }
            }
        }
        static void Category()
        {
            // MySQL Database Connection String
            string cs = @"server=172.16.9.1;userid=dbremoteuser;password=password;database=JustinCervenec_MDV229_Database_201903;port=8889";

            // Declare a MySQL Connection
            MySqlConnection conn = null;




            try
            {
                // Open a connection to MySQL 
                conn = new MySqlConnection(cs);
                conn.Open();

                //MySqlDataReader rdr = null;



                // Form SQL Statement
                string stm = "SELECT catagory_description FROM activity_catagories";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);


           

                //goes to data base for query
                MySqlDataReader rdr = cmd.ExecuteReader();




                while (rdr.Read())

                {
                    Console.WriteLine(rdr["catagory_description"]);
                 

                }


                // Execute SQL Statement and Convert Results to a String
                // string version = Convert.ToString(cmd.ExecuteScalar());

                // Output Results
                // Console.WriteLine("MySQL version : {0}", version);

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
    }
}
