using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisePg74
{
    class Program
    {
        static void Main(string[] args)
        {

            int age;
            bool DUI;
            int speedingTicket; 



            Console.WriteLine("Auto Insurance Basic Evaluator - Press Enter key to Continue");
            Console.ReadLine();
            Console.WriteLine("1. What is your age? ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("2. Do you have any DUIs? Please enter 'true' or 'false'.");
            DUI = bool.Parse(Console.ReadLine());
            Console.WriteLine("3. How many speeding tickets do you have?");
            speedingTicket = int.Parse(Console.ReadLine());

            if (age > 15 && DUI == false && speedingTicket < 3)
                Console.WriteLine("Congratulations. You qualify for insurance. Press the Enter key to Continue.");
            else
                Console.WriteLine("We're sorry, but you regretfully do not qualify for the insurance offered.");
                Console.WriteLine("Press the Enter key to Close.");
                Console.ReadLine(); 

        }
    }
}
