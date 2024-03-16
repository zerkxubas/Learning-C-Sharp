/** LAB6 */

/*

Write a program using C#
    a. To Insert data into Database Table.
    b. Display Data from your table
    c. Update data in your table

*/

// Note : Must install the System.Data.SqlClient using NuGet Package Manager.
using System;
using System.Data.SqlClient;
using System.Data;

namespace LAB6
{
    class Program
    {
        // Creating Static Connection String
        static string ConnectionString =  @"Data Source=ZERKBRO\SQLEXPRESS;Initial Catalog=dotnetlab;Integrated Security=True";
        static void Main(string[] args)
        {
            /**
                Create 3 different Pages for each section 
            */

            // a) Inseting Data using try catch block.
            try{
                // Using Static InsertData Method to store the record.
                InsertData("Samir","Acharya",28);
                Console.WriteLine("Data Inserted Successfully!");
            }catch(Exception e)
            {
                Console.WriteLine($"Failed! to insert data. : {e}");
            }

            
            // b) Displaying All the records. 
            try
            {
                // Display data from the table
                DisplayData();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed! to display data. : {e}");
            }

            // c) Updating A Single Record using ID
            try
            {
                // Update data in the table
                UpdateData(1, "UpdatedName", "UpdatedLastName", 30);
                // Now Displaying All data including Updating Data
                DisplayData();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed! to insert data. : {e}");
            }

        }

        // a) InsertData using static method
        static void InsertData(string firstName, string lastName, int age)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                // creating a query to insert data in the specific table.
                string query = "INSERT INTO dbo.users (id,firstName, lastName, age) VALUES (@ID,@FirstName, @LastName, @age)";

                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@ID", 3);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Age", age);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            Console.WriteLine("Done!.");
        }

        // c) Updating data by using selecting an ID.
        static void UpdateData(int id, string firstName, string lastName, int age)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "UPDATE dbo.users SET firstName = @FirstName, lastName = @LastName, age = @Age WHERE id = @ID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Age", age);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            Console.WriteLine("Data updated successfully.");
        }


        // b) Display Data of All Stored Users
        static void DisplayData()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "SELECT * FROM dbo.users";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    Console.WriteLine("ID\tFirstName\tLastName\tAge");
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["id"]}\t{reader["firstName"]}\t{reader["lastName"]}\t{reader["age"]}");
                    }
                }
            }
        }
    }
}
// That person who use this and didnot thanks me is GAY.