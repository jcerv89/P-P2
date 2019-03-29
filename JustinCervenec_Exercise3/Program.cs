using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustinCervenec_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            Dictionary<string, char> Gpa = new Dictionary<string, char>();
            //Dictioanry for student percent
            students.Add("Justin", 85);
            students.Add("Matthew", 92);
            students.Add("Sarah", 100);
            students.Add("Tim", 80);
            students.Add("Toni", 95);
            //dictionary for student letter grade
            Gpa.Add("Justin", 'B');
            Gpa.Add("Matthew", 'A');
            Gpa.Add("Sarah", 'A');
            Gpa.Add("Tim", 'B');
            Gpa.Add("Toni", 'A');

            bool programRunning = true;

            while (programRunning)
            {

                Console.WriteLine("What would you like to do with the students in the Fruits and Veggies course?\n");

                Console.WriteLine("Please choose an action");
                //display menu
                Console.WriteLine("1.Review students");
                Console.WriteLine("2.Review GPA");
                Console.WriteLine("3.Edit Student");
                Console.WriteLine("4.Exit");

                string userChoiceString = Console.ReadLine();
                int userChoice;
                //validate user input
                while (!int.TryParse(userChoiceString, out userChoice)&& userChoice<1||userChoice>4)
                {
                    Console.WriteLine("Select a valid option from the menu.");
                    userChoiceString = Console.ReadLine();
                }

                switch (userChoice)
                {
                    case 1:
                        //Shows students in the course
                        foreach (KeyValuePair<string, double> kvp in students)
                        {

                            Console.WriteLine(kvp.Key);
                        }

                        break;

                    case 2:

                        //Shows the student grades for the course
                        foreach (KeyValuePair<string, double> kvp in students)
                        {

                            Console.Write(kvp.Key+", ");

                        }
                        //display grades
                        foreach (KeyValuePair<string, char> kvp in Gpa)
                        {


                            Console.WriteLine(kvp.Value);

                        }


                        break;

                    case 3:
                        //Change students grade if selected
                        Console.WriteLine("Enter the student name");
                        string name = Console.ReadLine();
                        while (string.IsNullOrWhiteSpace(name))
                        {
                            Console.WriteLine("Please enter a students name");
                        }

                        Console.WriteLine("Enter the new grade");
                        string gradePercentString = Console.ReadLine();
                        double gradePercent;
                        while (!double.TryParse(gradePercentString, out gradePercent)&& gradePercent<0 || gradePercent>100)
                        {
                            Console.WriteLine("Please enter a valid grade percent. Example 50, or 95.5");
                        }

                        students[name] = gradePercent;

                        char grade = ' ';
                        //Goes through through the letter grades based on percent entered by user
                        if (gradePercent > 89.5 && gradePercent < 100)
                        {
                            grade= 'A';
                        }
                        if (gradePercent > 79.5 && gradePercent < 89.4)
                        {
                            grade= 'B';
                        }
                        if (gradePercent > 72.5 && gradePercent < 79.4)
                        {
                            grade = 'C';
                        }
                        if (gradePercent > 69.5 && gradePercent < 72.4)
                        {
                            grade = 'D';
                        }
                        if (gradePercent < 69.5)
                        {
                            grade = 'F';
                        }

                        Gpa[name] = grade;


                        break;


                    case 4:

                        Environment.Exit(0);//Exit program when selected.
                        break;


                }

            }
        }
    }
}
