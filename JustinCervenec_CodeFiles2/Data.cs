using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustinCervenec_CodeFiles2
{
    class Data
    {
        public static void JobListings()
        {
           

            // MySQL Database Connection String
            string cs = @"server=172.16.9.1;userid=dbremoteuser;password=password;database=Career Saver;port=8889";

            // Declare a MySQL Connection
            MySqlConnection conn = null;


            Console.WriteLine("Enter the Position you are searching for.");
            string position = Console.ReadLine();//Get user input
            while (string.IsNullOrWhiteSpace(position))//validate user input
            {
                Console.WriteLine("Enter a position.");
                position = Console.ReadLine();

            }

            Console.WriteLine("Enter the 5 digit zip code of the area you want to search.");
            string zipCodeString = Console.ReadLine();//Get user input
            int zipCode;//Variable for zip code numbers
            while (!int.TryParse(zipCodeString, out zipCode) || (zipCodeString.Length != 5))//Validate proper zip code input
            {
                Console.WriteLine("Enter valid 5 digit zip code for your search.");
                zipCodeString = Console.ReadLine();
            }



            try
            {
                // Open a connection to MySQL 
                conn = new MySqlConnection(cs);
                conn.Open();

                //MySqlDataReader rdr = null;



                // Form SQL Statement
                string stm = "SELECT position, company, location FROM Jobs WHERE position = @position limit 10";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);


                cmd.Parameters.AddWithValue("@position", position);
                cmd.Parameters.AddWithValue("@zipCodeString", zipCodeString);

                //goes to data base for query
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())

                {
                    Console.Write("Position: " + rdr["position"] + ", ");
                    Console.Write("Company: " + rdr["company"] + ", ");
                    Console.Write("Locatiion: " + rdr["location"] + ", \n");

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

        public static void SavedJobs()
        {
            Console.WriteLine("Start\n");

            // MySQL Database Connection String
            string cs = @"server=172.16.9.1;userid=dbremoteuser;password=password;database=Career Saver;port=8889";

            // Declare a MySQL Connection
            MySqlConnection conn = null;




            try
            {
                // Open a connection to MySQL 
                conn = new MySqlConnection(cs);
                conn.Open();

                //MySqlDataReader rdr = null;



                // Form SQL Statement
                string stm = "SELECT position, company, location FROM Saved";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);


                //cmd.Parameters.AddWithValue("@position", position);
                //cmd.Parameters.AddWithValue("@zipCodeString", zipCodeString);

                //goes to data base for query
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())

                {
                    Console.Write("Position: " + rdr["position"] + ", ");
                    Console.Write("Company: " + rdr["company"] + ", ");
                    Console.Write("Locatiion: " + rdr["location"] + ", \n");

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
