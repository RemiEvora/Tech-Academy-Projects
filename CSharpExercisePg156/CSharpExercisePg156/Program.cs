using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpExercisePg156
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Prints the current date and time to console. 
            Console.WriteLine("The date today is: " + DateTime.Now.ToShortDateString());
            Console.WriteLine("The time now is: " + DateTime.Now.ToShortTimeString());
            Console.ReadLine();

            //2. Asks the user for a number. 
            Console.WriteLine("Please give me a number - and I'll tell you what time it will be \nthat many hours later.");
            double userInput = Convert.ToInt32(Console.ReadLine());

            DateTime rightNow = DateTime.Now;

            //3.Prints to the console the exact time it will be in X hours, X being the nubmer the user entered in step 2. 
            DateTime nowPlusInput = rightNow.AddHours(userInput);
            Console.WriteLine("In " + userInput + " hours, it will be: " + nowPlusInput + ".");
            Console.ReadLine(); 

        }
    }
}
