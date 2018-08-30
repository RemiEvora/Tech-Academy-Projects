using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg165
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //1.Ask the user for his age.
            Console.WriteLine("Hi there. I want to calculate the year you were born.");
            Console.WriteLine("Can you tell me how old you are?");
            int userAge;
            try
            {
                userAge = Convert.ToInt32(Console.ReadLine());
                var todayDate = DateTime.Now;
                var userYears = todayDate.AddYears(-userAge);


            
                //2.Display the year user born.
                Console.WriteLine("I believe you were born in {0:yyyy}, is that right?", userYears);
                Console.ReadLine();
            }

            //3.Exceptions must be handled using "try .. catch".
            //4.Display appropriate error messages if user enters zero or negative numbers.
            //5.Display a general message if exception caused by anything else.

            catch (ZeroException)
            {
                if (userAge == 0)
                {
                    Console.WriteLine("Zero entered. Please enter a valid age.");
                    Console.ReadLine();
                    return;
                }
            }
            catch (NegativeException)
            {
                if (userAge < 0)
                {
                    Console.WriteLine("Negative value entered. Please enter a valid age.");
                    Console.ReadLine();
                    return;
                }
            }
            
            catch (Exception)
            {
                Console.WriteLine("I dunno what happened. Sorry, but I've got to close the program.");
                Console.ReadLine();
                return;
            }
        }
    }
}



