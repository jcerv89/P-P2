using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustinCervenec_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary d = new Dictionary();

            //To add Clues and Answers Manually
            d.addAnsClue("Banana", "This fruit is yellow and rich in potassium.");


            //getting all the clues
            var clues = d.Dict.Values.ToArray();
            string answer;
            int count = 0;

            do
            {
                //printing the first clue
                Console.WriteLine("Clue is:{0}", clues[0]);

                Console.WriteLine("---------------------------------------");

                Console.WriteLine("Enter the answer (First Letter Capital):");
                answer = Console.ReadLine();

                string found;

                //Tells user they are right when enrty in correct
                if (d.Dict.TryGetValue(answer, out found) && found == clues[0])
                {
                    Console.WriteLine("Congrats correct answer.\n");
                    break;
                }
                else//Reprompts user if correct
                {
                    Console.WriteLine("Please try again.. & Please use first letter capital for your answer....\n");
                    count++; //count for no of wrong attempts

                    //providing hints to user if user has entered wrong answer 10 times
                    if (count == 10)
                    {
                        Console.WriteLine("Hint: This fruit also needs peeled before eating.");
                    }
                }
            } while (answer != null);//Exits when user gives correct answer

            Console.ReadKey();
        }
    }
}
        
    

