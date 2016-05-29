using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SQLDBCOnsoleApp
{
    class Program
    {
        private static void mainMenu()
        {
            Console.Write("\nWelcome to Smcleod Technologies first MySQL Connection tutorial\n\n");
            Console.Write("Please Enter your name in to the line below\n");
            string name = Console.ReadLine();
            Console.Write("Welcome " + name + ".\n\nThis application was design to introduce CSharp to a My SQL Database\n");
            Console.Write("Please press any key to continue\n");
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            mainMenu();
            string dbConn = "Server=localhost;port=3306;Database=smcleodtechdb;Uid=smcleod;password=$3cur3d!";
            MySqlConnection conn = new MySqlConnection(dbConn);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "Select text from tutorialtbl where id=1";

            Console.WriteLine("Now we are going to grab the contence of out first record in the database\n");
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                
                Console.ReadLine();

                Console.WriteLine(ex.Message);
            }
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                Console.Write(reader["text"].ToString());
            }
            Console.WriteLine("See how easy that was when connecting to a MySql database and getting values out from a table?\n\n");
            Console.WriteLine("Now that this has been completed we can now close the connection to the database and end the application\n");
            Console.ReadLine();
            conn.Close();
            
        }
    }
}
