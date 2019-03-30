using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JustinCervenec_CodeFiles
{
    class DatabaseConnect
    {
        public static void Connect()
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
                string stm = "Select COUNT(*)From activity_log where category_description = 6";

                // Prepare SQL Statement
                MySqlCommand cmd = new MySqlCommand(stm, conn);


                //cmd.Parameters.AddWithValue(stm);
                //cmd.Parameters.AddWithValue("@zipCodeString", zipCodeString);

                //goes to data base for query
                MySqlDataReader rdr = cmd.ExecuteReader();

          


                while (rdr.Read())

                {
                    Console.WriteLine(rdr.GetInt16(0)+ " Times spent with family during the month.");
                    
                    

                }


         

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
