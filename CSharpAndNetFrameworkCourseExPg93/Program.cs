using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAndNetFrameworkCourseExPg93
{
    class Program
    {
        static void Main(string[] args)
        {
            //To test either program, comment out one or the other then execute//

            //============================================//
            //======While Boolean Comparison Exercise=====//
            //============================================//

            Console.WriteLine("Let's see how many times it takes to get two dice to match.");
            Console.WriteLine("Press the Enter key to begin");
            Console.ReadLine();

            DiceRoll:
            Random rndDice = new Random();
            int dice1 = rndDice.Next(1, 7);
            int dice2 = rndDice.Next(1, 7);
            bool matchingDice = dice1 == dice2;
            Console.WriteLine("Dice A= " + dice1 + " Dice B= " + dice2);
                       

            while (!matchingDice)
            {
                              
                if (dice1 != dice2)
                {
                    Console.WriteLine("Nope. Not a match. Try again.");
                    Console.ReadLine();
                    goto DiceRoll;
                }
                else
                {
                    Console.WriteLine("Congratulations! They match!");
                    Console.ReadLine();
                }

                
            }
            Console.ReadLine(); 


            //==============================================//
            //=====Do-While Boolean Comparison Exercise=====//
            //==============================================//

            //Console.WriteLine("This is a countdown. Press any key to continue.");
            //Console.ReadLine();
            //int counter = 10;
            //bool theEnd = counter == 0;

            //do
            //{
            //    Console.WriteLine(counter + "...");
            //    counter--;
            //    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));

            //    if (counter == 0)
            //    {
            //        Console.WriteLine("This is the end. Goodbye.");
            //        break;
            //    }
            //}

            //while (!theEnd);

            //Console.ReadLine();
        }
    }
}
