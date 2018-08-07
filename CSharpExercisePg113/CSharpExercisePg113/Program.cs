using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercisePg113
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversion Class Instantiation 
            ConversionMethods Calculator = new ConversionMethods();
            int result1;
            double result2;
            int result3;
            

            ////Request for Integer input, execute method one and display result to screen as an Integer. 
            //Console.WriteLine("Please give me a whole number: ");
            //int num01 = Convert.ToInt32(Console.ReadLine());

            //result1 = Calculator.IntAddition(num01);
            //Console.WriteLine("Ok. " + num01 + " plus 250 equals " + result1 + ".");
            //Console.ReadLine();


            ////Request for another (Decimal) input, execute method two, display result to screen as an Integer.
            //Console.WriteLine("Give me another number to work on: ");
            //double num02 = Convert.ToDouble(Console.ReadLine());

            //result2 = Calculator.DoubleMultiplication(num02);
            //Console.WriteLine(result2);
            //Console.ReadLine();


            //Request for another (String) input, execute method three, display result to screen as an Integer.
            Console.WriteLine("Give me one more number. But this time, I want you to write it out. " +
                "\nSo if you want \"5\", write out \"five\".");
            string num03 = Console.ReadLine();

            result3 = Calculator.StringSubtraction(num03);
            Console.WriteLine(result3);
            Console.ReadLine(); 

        }
    }
}
