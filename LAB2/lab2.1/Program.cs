/** Lab 2.1 */

// Write a C# program to create array with 5 items and 
// Calculate the sum of these numbers using for loop and foreach loop.

namespace LabSecond
{
    class Program{
        static void Main(string[] args){
            // Declaring Array of 5 items
            int[] userArray = new int[5];
            int totalSum = 0, totalResult=0;
            System.Console.WriteLine("You can enter 5 items...\n");
            // Taking 5 array items as input from user
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Item no. {0} : ",i);
                userArray[i] = Convert.ToInt32(Console.ReadLine());               
            }
            // Calculating Using For Loop
            Console.WriteLine("Calculating the sum using For Loop : ");
            for (int i = 0; i < 5; i++)
            {
                totalSum += userArray[i];
            }
            // Displaying the Total Resul of the calculation
            Console.WriteLine("The Total Result using For Loop is : {0}",totalSum);

            // Now Calculating Using For Each Loop
            Console.WriteLine("\nNow, Calculating the sum using For Each Loop : ");
            foreach (int item in userArray)
            {
                totalResult+=item;                
            }
            // Displaying the Total Resul of the calculation
            Console.WriteLine("Total Result using For Each Loop is : {0}",totalResult);
        }
    }
}