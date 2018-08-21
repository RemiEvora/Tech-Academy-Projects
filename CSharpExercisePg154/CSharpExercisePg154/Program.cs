using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace CSharpExercisePg154
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask a user for a number.
            Console.WriteLine("Hi there. Please give me a number from 1 to 10.");
            string userInput = Console.ReadLine();
            

            //2. Log that number to a text file. 
            /*(NOTE: To test, please put in your own directory file path)*/
            File.WriteAllText(@"C:\Users\Rembrandt.Evora\Desktop\2018 Tech Academy Bootcamp\C# & .NET Framework Course Documents\logtest2.txt", userInput);

            //3. Print the text file back to the user. 
            string readNumber = File.ReadAllText(@"C:\Users\Rembrandt.Evora\Desktop\2018 Tech Academy Bootcamp\C# & .NET Framework Course Documents\logtest2.txt");
            Console.ReadLine();
        }
    }
}
