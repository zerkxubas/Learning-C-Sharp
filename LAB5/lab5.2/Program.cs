/** Lab5.2 */

// Write a program to Handle DivdeByZeroException and IndexOutOfRangeException.

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Handling DivideByZeroException
            int number1 = 55;
            int number2 = 0;
            
            // Creating Array of 4 items.
            int[] arr = new int[3]{45,50,60};
            
            try{
                // creating exceptional error.
                int res = number1/number2;
                Console.WriteLine($"The result is {res}");
                
            }
            catch(DivideByZeroException){
                Console.WriteLine($"Divide by zero is not allowed.");
            }
            catch(Exception e){
                Console.WriteLine($"{e.Message}");
            }

            // Handling IndexOutOfRangeException
            try{
                // creating exceptional error case.
                arr[5] = 60; 
                
            }catch(IndexOutOfRangeException){
                Console.WriteLine($"Array out of bounds.");
                
            }catch(Exception e){
                Console.WriteLine($"{e.Message}");
            }
        }
    }
}