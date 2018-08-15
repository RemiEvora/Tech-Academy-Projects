using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg134
{
    public class Program
    {

        //1. Create an enum for the days of the week.
        public enum DaysOfTheWeek
        {
            Monday = 1,
            Tuesday = 55,
            Wednesday = 25,
            Thursday = 82,
            Friday = 32,
            Saturday = 99,
            Sunday = 100
        }
        static void Main(string[] args)
        {
            //4.Wrap the above statement in a try/catch block and have it print 
            //"Please enter an actual day of the week." to the console if an error occurs.
            try
            {

                //2. Prompt the user to enter the current day of the week.
                //3.Assign the value to a variable of that enum data type you just created.
               Console.WriteLine("What day is it today? Please enter the day of the week: ");
                string userInput = Console.ReadLine();
                DaysOfTheWeek dayOf = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);
                Console.WriteLine(dayOf);
                Console.ReadLine();
                
            } 
            catch (ArgumentException e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine(); 
            }

        }
    }
}
